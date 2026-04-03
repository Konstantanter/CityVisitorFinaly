using CityVisitorFinaly.AppData;
using CityVisitorFinaly.AppData.DataRegions;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace CityVisitorFinaly;

public partial class RegionsPage : ContentPage
{
    public ObservableCollection<RegionsRF> RegionList { get; set; }

    public RegionsPage()
    {
        InitializeComponent();

        RegionList = new ObservableCollection<RegionsRF>();

        // ✅ Привязка источника данных (один раз)
        listViewRegion.ItemsSource = RegionList;


        //if (!System.IO.File.Exists(App.DataBasePath))
       
            // 🔥 Инициализация БД и загрузка данных — ТОЛЬКО один раз при создании страницы
            InitializeDataAsync();
    }

    // 🔥 Асинхронная инициализация (не блокирует UI)
    private async void InitializeDataAsync()
    {
        try
        {
          
                await App.Db.SeedDatabase();
           
            // 2. Загружаем и отрисовываем данные
            await Paintdata();
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"❌ Ошибка инициализации: {ex.Message}");
            await DisplayAlert("Ошибка", "Не удалось загрузить данные", "OK");
        }
    }

    // ✅ Оптимизированная загрузка: 2 запроса вместо 99
    public async Task Paintdata()
    {
       

       
            // 1️⃣ Загружаем все регионы (1 запрос)
            var regions = await App.Db.GetRegions();

            // 2️⃣ Загружаем ВСЕ города одним запросом (1 запрос вместо 85!)
            var allCities = await App.Db.GetAllCitiesAsync();

            // 3️⃣ Группируем города по RegionId в памяти (мгновенно)
            var citiesByRegion = allCities.GroupBy(c => c.Regionid)
                                          .ToDictionary(g => g.Key, g => g.ToList());

            // 4️⃣ Заполняем коллекцию
            foreach (var region in regions)
            {
                var newReg = new RegionsRF(region);

                // Берём города из словаря за O(1)
                if (citiesByRegion.TryGetValue(region.Id, out var cityList))
                {
                    newReg.AddCities(cityList);
                }

                RegionList.Add(newReg); // ✅ UI обновится сам благодаря ObservableCollection
            }

            Debug.WriteLine($"📊 Загружено: {RegionList.Count} регионов");
        
        
    }
    protected override void OnDisappearing()
    {
        base.OnDisappearing();

        // 🔥 Очистка коллекции, если страница больше не нужна
        // (например, если это временный экран)
        RegionList?.Clear();

        // Если используешь подписки — отпишись здесь
        // MessagingCenter.Unsubscribe<...>(this, "...");
    }
    async void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
    {
        if (e.Item is RegionsRF selectedRegion)
        {
            await Navigation.PushAsync(new CitiesPage(selectedRegion));
        }
        ((ListView)sender).SelectedItem = null;
    }
}