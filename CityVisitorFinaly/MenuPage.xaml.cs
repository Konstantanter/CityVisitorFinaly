using CityVisitorFinaly.AppData;
using System.Diagnostics;

namespace CityVisitorFinaly;

public partial class MenuPage : ContentPage
{
    Page MainPage;

	public MenuPage(Page page)
	{
        InitializeComponent();
    }
    private async void ButtonMaps_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MapsPage());


    }
    protected override async void OnAppearing()
    {

        base.OnAppearing();

        try
        {


            if (!System.IO.File.Exists(App.DataBasePath))
            {

                loadingIndicator.IsVisible = true;
                loadingIndicator.IsRunning = true;
                Button1.IsVisible = false;
                Button2.IsVisible = false;
                DataBase Db = new DataBase(App.DataBasePath);
 
                await Db.SeedDatabase();
                loadingIndicator.IsVisible = false;
                loadingIndicator.IsRunning = false;
                Button1.IsVisible = true;
                Button2.IsVisible = true;
            }
        }
        catch (Exception ex)
        {
           await DisplayAlert("Ошибка", "Не удалось загрузить данные", "OK");
        }
    }
    private async void ButtonRegion_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegionsPage());
    }
}