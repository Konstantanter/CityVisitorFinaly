using CityVisitorFinaly.AppData;
using System.Collections.ObjectModel;

namespace CityVisitorFinaly;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class CitiesPage : ContentPage
{
    #region Переменные
    /// <summary>
    /// Заголовок формы - название региона
    /// </summary>
    public string TitleCities { get; set; }
    /// <summary>
    /// Путь до герба города
    /// </summary>
    public string PathImage { get; set; }
    /// <summary>
    /// Список городов региона
    /// </summary>
    public ObservableCollection<City> CityList { get; set; }
    /// <summary>
    /// Название города
    /// </summary>
    public string NameCity;
    /// <summary>
    /// Переменная для хранения региона
    /// </summary>
    Regions tmpreg;
    #endregion
    public CitiesPage()
    {
        InitializeComponent();
    }

    public CitiesPage(Regions selectedRegion)
    {
        InitializeComponent();

        TitleCities = selectedRegion.Name;
        PathImage = selectedRegion.PathImage;
        tmpreg = selectedRegion;
        CityList = selectedRegion.ListCities;
        NameCity = selectedRegion.Name;
        BindingContext = this;
    }
    async void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
    {
        if (e.Item is City selectedCity)
        {
            await Navigation.PushAsync(new CityPage(selectedCity, tmpreg));
        }
        ((ListView)sender).SelectedItem = null;

    }
}