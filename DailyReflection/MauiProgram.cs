using CommunityToolkit.Maui;
using DailyReflection.DependencyInjection;
using DailyReflection.Presentation.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DailyReflection;

public static class MauiProgram
{
	public static MauiApp? App { get; private set; }

	public static IServiceProvider? ServiceProvider { get; private set; }

	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
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

		App = builder.Build();
		ServiceProvider = App.Services;

		return App;
	}
}
