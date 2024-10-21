using System.Globalization;

namespace CityVisitorFinaly.AppData
{
    public class Image
    {
        public string FileName { get; set; }
        public ImageSource Source => ImageSource.FromFile(FileName);
    }
    public class BackgroundToTextColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Microsoft.Maui.Graphics.Color backgroundColor = Microsoft.Maui.Graphics.Colors.White;
            if (value != null)
            {
                backgroundColor = (Microsoft.Maui.Graphics.Color)value;
            }

            if (backgroundColor == Microsoft.Maui.Graphics.Colors.Green) return Microsoft.Maui.Graphics.Colors.White;

            else return Microsoft.Maui.Graphics.Colors.Black;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class VisitedToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string VisitedPercent)
            {
                if (VisitedPercent.Equals("100 %"))
                    return Microsoft.Maui.Graphics.Colors.Green;
            }


            return Microsoft.Maui.Graphics.Colors.Transparent;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class StateToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is State state)
            {
                switch (state)
                {
                    case State.Visited:
                        return Microsoft.Maui.Graphics.Colors.Green;
                    case State.VisitedTransit:
                        return Microsoft.Maui.Graphics.Colors.Yellow;
                    case State.NotVisited:
                        return Microsoft.Maui.Graphics.Colors.White;
                    default: return Microsoft.Maui.Graphics.Colors.White;
                }
            }

            return Microsoft.Maui.Graphics.Colors.Transparent;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
