using Dentistry.Services;
using Dentistry.Views;
using Microsoft.Extensions.Logging;

namespace Dentistry
{
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

            // Register services
            builder.Services.AddSingleton<PatientService>();


            // Register views
            builder.Services.AddTransient<PatientListPage>();
            builder.Services.AddTransient<PatientDetailPage>();


            // Register view models
            builder.Services.AddTransient<ViewModels.PatientListViewModel>();
            builder.Services.AddTransient<ViewModels.PatientDetailsViewModel>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
