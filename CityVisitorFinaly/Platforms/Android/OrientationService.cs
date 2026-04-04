using Android.Content.PM;
using CityVisitorFinaly.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityVisitorFinaly.Platforms.Android
{
    public class OrientationService : IOrientationService
    {
        public void SetLandscape() => Microsoft.Maui.ApplicationModel.Platform.CurrentActivity.RequestedOrientation = ScreenOrientation.Landscape;
        public void SetPortrait() => Microsoft.Maui.ApplicationModel.Platform.CurrentActivity.RequestedOrientation = ScreenOrientation.Portrait;
        public void SetUnspecified() => Microsoft.Maui.ApplicationModel.Platform.CurrentActivity.RequestedOrientation = ScreenOrientation.Unspecified;
    }
}
