using CityVisitorFinaly.AppData;
using System.Collections.ObjectModel;

namespace CityVisitorFinaly;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class CitiesPage : ContentPage
{

    public string TitleCities { get; set; }
    public string PathImage { get; set; }
    public ObservableCollection<City> CityList { get; set; }


    public string NameCity;
    public CitiesPage()
    {
        InitializeComponent();
    }

    Regions tmpreg;
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