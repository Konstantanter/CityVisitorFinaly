using CityVisitorFinaly.AppData;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace CityVisitorFinaly;

public partial class RegionsPage : ContentPage
{
    // ✅ Инициализируем коллекцию сразу
    public ObservableCollection<RegionsRF> RegionList { get; set; } = new ObservableCollection<RegionsRF>();

    private bool _isDataLoaded = false; 

    public RegionsPage()
    {
        InitializeComponent();
       
        listViewRegion.ItemsSource = RegionList;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (_isDataLoaded)
        {
            return;
        }

        await LoadDataAsync();
    }

    private async Task LoadDataAsync()
    {
        try
        {
    
            RegionList.Clear();

            var regions = await App.Db.GetRegions();
            var allCities = await App.Db.GetAllCitiesAsync();
            var citiesByRegion = allCities.GroupBy(c => c.Regionid)
                                          .ToDictionary(g => g.Key, g => g.ToList());

            foreach (var region in regions)
            {
                var newReg = new RegionsRF(region);
                if (citiesByRegion.TryGetValue(region.Id, out var cityList))
                {
                    newReg.AddCities(cityList);
                }
                RegionList.Add(newReg);
            }

            _isDataLoaded = true; 
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Ошибка загрузки регионов: {ex.Message}");
            await DisplayAlert("Ошибка", "Не удалось загрузить данные", "OK");
        }
        
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