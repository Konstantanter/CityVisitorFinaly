using CityVisitorFinaly.AppData;
using CityVisitorFinaly.AppData.DataRegions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
namespace CityVisitorFinaly;

public partial class RegionsPage : ContentPage
{


    public async Task SeedDatabase()
    {
        if (await App.Db.GetRegionsCountAsync() > 0)
            return;

        Assembly assembly = GetType().GetTypeInfo().Assembly;
       // using Stream stream = assembly.GetManifestResourceStream("CityVisitorFinaly.Resources.Raw.regions.json");
        using var stream = await FileSystem.OpenAppPackageFileAsync("regions.json");
        if (stream == null) return;

        using var reader = new StreamReader(stream);
        var json = await reader.ReadToEndAsync();
        var regionsDto = JsonConvert.DeserializeObject<List<RegionDto>>(json);

        var regionsToInsert = new List<RegionsDB>();
        var citiesToInsert = new List<CityDB>();
        var nameToRegionMap = new Dictionary<string, RegionsDB>();

        foreach (var regDto in regionsDto)
        {
            var region = new RegionsDB
            {
                Name = regDto.Name,
                PathImage = regDto.ImagePath,
                IdRegionsMaps = regDto.MapId
            };

            nameToRegionMap[regDto.Name] = region; // Сохраняем в словарь по имени
            regionsToInsert.Add(region);

            foreach (var cityDto in regDto.Cities)
            {
                citiesToInsert.Add(new CityDB
                {
                    Name = cityDto.Name,
                    ImagePath = cityDto.Image,
                    StateCity = State.NotVisited,
                    TempRegionName = regDto.Name
                });
            }
        }

        // 🔥 Выполняем всё в одной транзакции
        await App.Db.Connection.RunInTransactionAsync(conn =>
        {
            // 1. Вставляем регионы — теперь у них есть реальные Id
            conn.InsertAll(regionsToInsert);

            // 2. Проставляем Regionid у городов, используя словарь и временное имя
            foreach (var city in citiesToInsert)
            {
                if (!string.IsNullOrEmpty(city.TempRegionName) &&
                    nameToRegionMap.TryGetValue(city.TempRegionName, out var region))
                {
                    city.Regionid = region.Id; // ✅ Теперь Id корректный
                }
            }

            // 3. Вставляем города с правильными внешними ключами
            conn.InsertAll(citiesToInsert);
        });

        Debug.WriteLine($"✅ Загружено: {regionsToInsert.Count} регионов, {citiesToInsert.Count} городов");
    }


}
