using CityVisitorFinaly.AppData;
using System.Collections.ObjectModel;

namespace CityVisitorFinaly;

public partial class RegionsPage : ContentPage
{
    public ObservableCollection<Regions> RegionList { get; set; }
    public RegionsPage()
	{
        //App.DeleteDataBase();
		InitializeComponent();
        RegionList = new ObservableCollection<Regions>();
        if (!System.IO.File.Exists(App.DataBasePath))
        {
            InitCities();
        }
        Paintdata();
    }
    public async void Paintdata()
    {

        var regions = await App.Db.GetRegions();

        foreach (var region in regions)
        {
            Regions newReg = new Regions(region);

            var newListCities = await App.Db.GetCitiesFromRegion(region.Id);
            newReg.AddCities(newListCities);
            RegionList.Add(newReg);
        }
        listViewRegion.BindingContext = RegionList;
        BindingContext = this;
    }
    async void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
    {
        if (e.Item is Regions selectedRegion)
        {

            await Navigation.PushAsync(new CitiesPage(selectedRegion));
        }
         ((ListView)sender).SelectedItem = null;
    }
}