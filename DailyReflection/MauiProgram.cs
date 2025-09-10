using DailyReflection.DependencyInjection;
using DailyReflection.Presentation.DependencyInjection;
using DailyReflection.Services.Settings;
using DailyReflection.Services.Share;
using Microsoft.Extensions.Logging;

namespace DailyReflection
{
	public static class MauiProgram
	{
		public static MauiApp? App { get; private set; }

		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				});


	
			builder.Services.AddPages();
			builder.Services.AddPlatformServices();
			builder.Services.AddPresentationDependencies();

#if DEBUG
			builder.Logging.AddDebug();
#endif

			return App = builder.Build();
		}
	}
}
