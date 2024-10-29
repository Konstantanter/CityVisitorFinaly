using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly;

public partial class App : Application
{
    static DataBase db;


    public static string DataBasePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Citiesbase.db3");
    public static string DataSVGPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Test3.svg");
    // public static string DataSVGPath1 = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Test3_1.svg");

    public static DataBase Db
    {
        get
        {
            if (db == null)
            {
                db = new DataBase(DataBasePath);
            }
            return db;
        }
    }

    public  void ShowForm(Page page)
    {
        MainPage = new NavigationPage(new MenuPage(page));
    }
    public App()
    {
        InitializeComponent();
        //  System.IO.File.Delete(DataSVGPath);
        //System.IO.File.Delete(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Test3_1.svg"));
        //System.IO.File.Delete(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Test3_1.svg"));
        // DeleteDataBase();
        MainPage = new NavigationPage(new MenuPage(MainPage));

        //if (!System.IO.File.Exists(DataSVGPath))
        //{
        //    string content;
        //    AssetManager assets = Android.App.Application.Context.Assets;

        //    using (StreamReader sr = new StreamReader(assets.Open("Test3.svg")))
        //    {
        //        content = sr.ReadToEnd();
        //    }
        //    System.IO.File.WriteAllText(DataSVGPath, content, System.Text.Encoding.Default);
        //}

        // DeleteDataBase();
        ////MainPage = new MapsPage();
        // DeleteDataBase();

        //Regions Adygea = new Regions("Республика Адыгея", "Adygea.png");
        //Adygea.IdRegionsMaps = "path16";
        //City Adygeisk = new City("Адыгейск", "Adygeisk.png");
        //MainPage = new CityPage(Adygeisk, Adygea);
    }
    public static void DeleteDataBase()
    {
        System.IO.File.Delete(DataBasePath);
    }

    protected override void OnStart()
    {

    }

    protected override void OnSleep()
    {
    }

    protected override void OnResume()
    {
    }
}
