using CityVisitorFinaly.AppData;
using CityVisitorFinaly.AppData.DataRegions;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Xml.XPath;
namespace CityVisitorFinaly;

public partial class RegionsPage : ContentPage
{
    // ✅ Коллекция создается сразу как свойство класса
    public ObservableCollection<RegionsRF> RegionList { get; set; } = new ObservableCollection<RegionsRF>();

    private bool _isDataLoaded = false; // Флаг, чтобы не загружать данные повторно

    // 1. КОНСТРУКТОР: выполняется ОДИН РАЗ при создании страницы
    public RegionsPage()
    {
        InitializeComponent(); // ✅ InitializeComponent() должен быть ТОЛЬКО здесь

        // ✅ Привязываем источник данных к ListView. Это делается один раз.
        //    Теперь ListView "слушает" изменения в RegionList.
        listViewRegion.ItemsSource = RegionList;
    }

    // 2. OnAppearing: выполняется КАЖДЫЙ РАЗ, когда страница появляется
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        // Если данные уже загружены, ничего не делаем
        // (полезно, когда ты возвращаешься с предыдущей страницы)
        if (_isDataLoaded) return;

        try
        {
            // Убедимся, что база данных создана и наполнена (если нужно)
            // Эту проверку можно вынести в App.xaml.cs для однократного выполнения при старте
            if (!System.IO.File.Exists(App.DataBasePath))
            {
                // Тут должен быть твой DbInitializer.SeedDatabase(), который читает JSON
                await SeedDatabase();
            }

            await LoadAndPaintData();
            _isDataLoaded = true; // Отмечаем, что данные загружены
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"❌ Ошибка загрузки: {ex.Message}");
            await DisplayAlert("Ошибка", "Не удалось загрузить данные", "OK");
        }
    }

    // 3. Метод загрузки данных
    public async Task LoadAndPaintData()
    {
        // Показываем индикатор
        loadingIndicator.IsVisible = true;
        loadingIndicator.IsRunning = true;

        try
        {
            var regionsFromDb = await App.Db.GetRegions();
            var allCitiesFromDb = await App.Db.GetAllCitiesAsync();

            // Твой эффективный способ группировки - он отличный!
            var citiesByRegion = allCitiesFromDb.GroupBy(c => c.Regionid)
                                                .ToDictionary(g => g.Key, g => g.ToList());

            // Очищаем старые данные перед добавлением новых
            RegionList.Clear();

            foreach (var region in regionsFromDb)
            {
                var newReg = new RegionsRF(region); // Создаем объект для отображения
                if (citiesByRegion.TryGetValue(region.Id, out var cityList))
                {
                    newReg.AddCities(cityList); // Добавляем города
                }
                RegionList.Add(newReg); // ✅ Просто добавляем в коллекцию. UI обновится сам!
            }
        }
        finally
        {
            // Скрываем индикатор в любом случае (даже если была ошибка)
            loadingIndicator.IsVisible = false;
            loadingIndicator.IsRunning = false;
            Debug.WriteLine($"📊 В RegionList: {RegionList.Count} регионов");
        }
    }

    // Обработчик нажатия остаётся без изменений
    async void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
    {
        if (e.Item is RegionsRF selectedRegion)
        {
            await Navigation.PushAsync(new CitiesPage(selectedRegion));
        }
        // Сбрасываем выделение
        ((ListView)sender).SelectedItem = null;
    }
}