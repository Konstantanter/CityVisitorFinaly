namespace CityVisitorFinaly;

public partial class MenuPage : ContentPage
{
    Page MainPage;
	public MenuPage(Page page)
	{
     

        InitializeComponent();
	}
    private void ButtonMaps_Clicked(object sender, EventArgs e)
    {
        App app = new App();
        app.ShowForm(new NavigationPage(new MapsPage()));
   
    }
    private void ButtonRegion_Clicked(object sender, EventArgs e)
    {
        App app = new App();
        app.ShowForm(new NavigationPage(new RegionsPage()));
        //DisplayAlert("Информационное сообщение", "Ты кликнул на Регионы", "Ок");
    }
}