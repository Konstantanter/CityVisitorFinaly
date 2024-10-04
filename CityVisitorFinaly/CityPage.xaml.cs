using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly;

public partial class CityPage : ContentPage
{
    public string CoatOfArmsImage { get; set; }

    public string NameCity { get; set; }
    public string NameReg { get; set; }
    City city;
    Regions myReg;
   
   
    public CityPage(City selectedCity, AppData.Regions region)
    {
        InitializeComponent();
        myReg = region;

        NameCity = selectedCity.Name;
        NameReg = region.Name;
        CoatOfArmsImage = selectedCity.ImagePath;
        //BindingContext = selectedCity;
        city = selectedCity;


        State state = city.State;
        if (state == State.NotVisited)
        {
            picker.Title = "�� �������";
        }
        if (state == State.Visited)
        {
            picker.Title = "����������";
        }
        if (state == State.VisitedTransit)
        {
            picker.Title = "��������";
        }
        if (city.DataVisited != null)
        {
            datePicker.Date = DateTime.Parse(city.DataVisited);
        }
        Switcher.IsToggled = city.Magned;
        Switcher.Toggled += OnToggled;
        //picker.SelectedIndex = 0;

        datePicker.DateSelected += DatePicker_DateSelected;
        datePicker.MaximumDate = DateTime.Now;
        // �������� ��������� �����������

        // �������� ������ �����������, ���� ��� ����������

        // �������� ��������� ����������� � �������� ���������� ListView

        BindingContext = this;
    }
    void OnToggled(object sender, ToggledEventArgs e)
    {
        city.Magned = Switcher.IsToggled;
        CityDB CityDB = new CityDB(city, myReg.IdRegion);
        CityDB.SaveCity();
    }
    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        city.DataVisited = datePicker.Date.ToShortDateString();
        CityDB CityDB = new CityDB(city, myReg.IdRegion);
        CityDB.SaveCity();
    }
    private void picker_SelectedIndexChanged(object sender, EventArgs e)
    {
        int i = picker.SelectedIndex;
        if (i == 0)
        {
            city.State = State.Visited;
        }
        if (i == 1)
        {
            city.State = State.VisitedTransit;
        }
        if (i == 2)
        {
            city.State = State.NotVisited;
        }
        city.DataVisited = datePicker.Date.ToShortDateString();
        int cur = myReg.ListCities.Count(a => a.State != State.NotVisited);
        double a1 = cur, a2 = myReg.ListCities.Count;
        myReg.SetVisitPercentage(a1 / a2 * 100.0);
        myReg.SaveReg(city);
    }
    //private void SettingsIcon_Tapped(object sender, EventArgs e)
    //{
    //    // ����� ����� �������� ��� ��� ��������� ������� �� ������ ��������
    //    // ��������, ������� �������� �������� ��� ��������� ��������������� ��������
    //}

    //private void PhotoIcon_Tapped(object sender, EventArgs e)
    //{
    //    // ����� ����� �������� ��� ��� ��������� ������� �� ������ ��������
    //    // ��������, ������� �������� �������� ��� ��������� ��������������� ��������
    //}

    //private void GalleryIcon_Tapped(object sender, EventArgs e)
    //{
    //    // ����� ����� �������� ��� ��� ��������� ������� �� ������ ��������
    //    // ��������, ������� �������� �������� ��� ��������� ��������������� ��������
    //}

    //private void VideoIcon_Tapped(object sender, EventArgs e)
    //{
    //    // ����� ����� �������� ��� ��� ��������� ������� �� ������ ��������
    //    // ��������, ������� �������� �������� ��� ��������� ��������������� ��������
    //}
}

