using DailyReflection.DependencyInjection;
using DailyReflection.Presentation.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DailyReflection;

public static class Startup
{
	public static IServiceProvider ServiceProvider { get; set; }

	public static void Init(Action<HostBuilderContext, IServiceCollection> platformConfigure)
	{
		var host = Host.CreateDefaultBuilder()
			.ConfigureAppConfiguration(config =>
			{
				config.SetFileProvider(new EmbeddedFileProvider(typeof(Startup).Assembly));
				config.AddJsonFile("appsettings.json");
			})
			.ConfigureServices((ctx, sc) =>
			{
				ConfigureServices(ctx, sc);
				platformConfigure?.Invoke(ctx, sc);

			})
			.ConfigureLogging(builder =>
			{
				builder.AddConsole();
			})
			.Build();

		ServiceProvider = host.Services;
	}

	private static void ConfigureServices(HostBuilderContext ctx, IServiceCollection services)
	{
		services.AddPages();
		services.AddPresentationDependencies();
	}
}