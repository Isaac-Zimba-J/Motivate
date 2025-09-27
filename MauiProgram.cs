using Microsoft.Extensions.Logging;
using Motivate.Repositories;
using Motivate.Repositories.Contracts;
using Motivate.Services;
using Motivate.Services.Contracts;
using Motivate.ViewModels;
using Motivate.Views;

namespace Motivate;

public static class MauiProgram
{
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

#if DEBUG
		builder.Logging.AddDebug();
#endif

		var dbPath = Path.Combine(FileSystem.AppDataDirectory, "quotes.db3");
		builder.Services.AddSingleton(new SQLite.SQLiteAsyncConnection(dbPath));


		//Dependency Injection
		builder.Services.AddTransient<IQuoteService, QuoteService>();
		builder.Services.AddTransient<IQuoteRepository, QuoteRepository>();

		//register services here
		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddTransient<MainPageViewModel>();
		builder.Services.AddSingleton<AboutPage>();




		return builder.Build();
	}
}
