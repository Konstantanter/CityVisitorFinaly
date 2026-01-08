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
    private async void ButtonRegion_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegionsPage());
    }
}