using CityVisitorFinaly.AppData;

namespace CityVisitorFinaly
{
    public partial class RegionsPage : ContentPage
    {


        /// <summary>
        /// Инициализация Краснодарского края
        /// </summary>
        public void KrasnodarKrai()
        {
            Regions KrasnodarKrai = new Regions("Краснодарский край", "KrasnodarKrai.png")
            {
                IdRegionsMaps = "path72"
            };

            KrasnodarKrai.AddCities(new City("Абинск", "Abinsk.png"));
            KrasnodarKrai.AddCities(new City("Анапа", "Anapa.png"));
            KrasnodarKrai.AddCities(new City("Апшеронск", "Apsheronsk.png"));
            KrasnodarKrai.AddCities(new City("Армавир", "Armavir.png"));
            KrasnodarKrai.AddCities(new City("Белореченск", "Belorechensk.png"));
            KrasnodarKrai.AddCities(new City("Геленджик", "Gelendzhik.png"));
            KrasnodarKrai.AddCities(new City("Горячий Ключ", "Goryachy_Klyuch.png"));
            KrasnodarKrai.AddCities(new City("Гулькевичи", "Gulkevichi.png"));
            KrasnodarKrai.AddCities(new City("Ейск", "Eysk.png"));
            KrasnodarKrai.AddCities(new City("Кореновск", "Korenovsk.png"));
            KrasnodarKrai.AddCities(new City("Краснодар", "Krasnodar.png"));
            KrasnodarKrai.AddCities(new City("Кропоткин", "Kropotkin.png"));
            KrasnodarKrai.AddCities(new City("Крымск", "Krymsk.png"));
            KrasnodarKrai.AddCities(new City("Курганинск", "Kurganinsk.png"));
            KrasnodarKrai.AddCities(new City("Лабинск", "Labinsk.png"));
            KrasnodarKrai.AddCities(new City("Новокубанск", "Novokubansk.png"));
            KrasnodarKrai.AddCities(new City("Новороссийск", "Novorossiysk.png"));
            KrasnodarKrai.AddCities(new City("Приморско-Ахтарск", "PrimorskoAkhtarsk.png"));
            KrasnodarKrai.AddCities(new City("Свавянск-на-Кубани", "SlavyansknaKubani.png"));
            KrasnodarKrai.AddCities(new City("Сочи", "Sochi.png"));
            KrasnodarKrai.AddCities(new City("Темрюк", "Temryuk.png"));
            KrasnodarKrai.AddCities(new City("Тимашёвск", "Timashevsk.png"));
            KrasnodarKrai.AddCities(new City("Тихорецк", "Tikhoretsk.png"));
            KrasnodarKrai.AddCities(new City("Туапсе", "Tuapse.png"));
            KrasnodarKrai.AddCities(new City("Усть-Лабинск", "UstLabinsk.png"));
            KrasnodarKrai.AddCities(new City("Хадыженск", "Khadyzhensk.png"));

            AddRegToDB(KrasnodarKrai);
        }
    }
}
