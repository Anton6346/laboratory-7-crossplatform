using Microsoft.Extensions.DependencyInjection;
using University.MobileApp.Services;

namespace University.MobileApp;

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
            });

        // 🔹 ОСЬ ТУТ 👇
        builder.Services.AddSingleton<ApiService>();
        builder.Services.AddSingleton<AuthService>();

        return builder.Build();
    }
}
