using Microsoft.Extensions.Logging;
using SkiaSharp.Views.Maui.Controls.Hosting;
using CityVisitorFinaly.Services;
namespace CityVisitorFinaly;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{

		var builder = MauiApp.CreateBuilder();

		builder
			.UseMauiApp<App>()

			.UseSkiaSharp()
			//.UseMauiMaps()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if ANDROID
builder.Services.AddSingleton<CityVisitorFinaly.Services.IOrientationService, CityVisitorFinaly.Platforms.Android.OrientationService>();
//#elif IOS
//        builder.Services.AddSingleton<CityVisitorFinaly.Services.IOrientationService, CityVisitorFinaly.Platforms.iOS.OrientationService>();
#endif


		return builder.Build();

	}
}
