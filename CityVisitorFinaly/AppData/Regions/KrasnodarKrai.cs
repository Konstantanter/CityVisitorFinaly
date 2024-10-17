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
            City Abinsk = new City("Абинск", "Abinsk.png");
            City Anapa = new City("Анапа", "Anapa.png");
            City Apsheronsk = new City("Апшеронск", "Apsheronsk.png");
            City Armavir = new City("Армавир", "Armavir.png");
            City Belorechensk = new City("Белореченск", "Belorechensk.png");
            City Gelendzhik = new City("Геленджик", "Gelendzhik.png");
            City Goryachy_Klyuch = new City("Горячий Ключ", "Goryachy_Klyuch.png");
            City Gulkevichi = new City("Гулькевичи", "Gulkevichi.png");
            City Eysk = new City("Ейск", "Eysk.png");
            City Korenovsk = new City("Кореновск", "Korenovsk.png");
            City Krasnodar = new City("Краснодар", "Krasnodar.png");
            City Kropotkin = new City("Кропоткин", "Kropotkin.png");
            City Krymsk = new City("Крымск", "Krymsk.png");
            City Kurganinsk = new City("Курганинск", "Kurganinsk.png");
            City Labinsk = new City("Лабинск", "Labinsk.png");
            City Novokubansk = new City("Новокубанск", "Novokubansk.png");
            City Novorossiysk = new City("Новороссийск", "Novorossiysk.png");
            City PrimorskoAkhtarsk = new City("Приморско-Ахтарск", "PrimorskoAkhtarsk.png");
            City SlavyansknaKubani = new City("Свавянск-на-Кубани", "SlavyansknaKubani.png");
            City Sochi = new City("Сочи", "Sochi.png");
            City Temryuk = new City("Темрюк", "Temryuk.png");
            City Timashevsk = new City("Тимашёвск", "Timashevsk.png");
            City Tikhoretsk = new City("Тихорецк", "Tikhoretsk.png");
            City Tuapse = new City("Туапсе", "Tuapse.png");
            City UstLabinsk = new City("Усть-Лабинск", "UstLabinsk.png");
            City Khadyzhensk = new City("Хадыженск", "Khadyzhensk.png");

            KrasnodarKrai.AddCities(Abinsk);
            KrasnodarKrai.AddCities(Anapa);
            KrasnodarKrai.AddCities(Apsheronsk);
            KrasnodarKrai.AddCities(Armavir);
            KrasnodarKrai.AddCities(Belorechensk);
            KrasnodarKrai.AddCities(Gelendzhik);
            KrasnodarKrai.AddCities(Goryachy_Klyuch);
            KrasnodarKrai.AddCities(Gulkevichi);
            KrasnodarKrai.AddCities(Eysk);
            KrasnodarKrai.AddCities(Korenovsk);
            KrasnodarKrai.AddCities(Krasnodar);
            KrasnodarKrai.AddCities(Kropotkin);
            KrasnodarKrai.AddCities(Krymsk);
            KrasnodarKrai.AddCities(Kurganinsk);
            KrasnodarKrai.AddCities(Labinsk);
            KrasnodarKrai.AddCities(Novokubansk);
            KrasnodarKrai.AddCities(Novorossiysk);
            KrasnodarKrai.AddCities(PrimorskoAkhtarsk);
            KrasnodarKrai.AddCities(SlavyansknaKubani);
            KrasnodarKrai.AddCities(Sochi);
            KrasnodarKrai.AddCities(Temryuk);
            KrasnodarKrai.AddCities(Timashevsk);
            KrasnodarKrai.AddCities(Tikhoretsk);
            KrasnodarKrai.AddCities(Tuapse);
            KrasnodarKrai.AddCities(UstLabinsk);
            KrasnodarKrai.AddCities(Khadyzhensk);
            AddRegToDB(KrasnodarKrai);
        }
    }
}
