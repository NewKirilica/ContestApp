using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls; // чтобы явно видеть Application
using ContestApp.Infrastructure;
using ContestApp.UI.Pages;
using ContestApp.UI.ViewModels;
using ContestApp.Application;

namespace ContestApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder
                .UseMauiApp<App>() // правильно!
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "contest.db");
            var connectionString = $"Data Source={dbPath}";

            builder.Services
                .AddApplication() // ← должен быть доступен, если метод реализован
                .AddInfrastructure(connectionString)
                .AddTransient<NominationsPage>()
                .AddTransient<NominationsViewModel>();

            return builder.Build();
        }
    }
}
