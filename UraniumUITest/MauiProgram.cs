using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using UraniumUI;

namespace UraniumUITest
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .RegisterPages()
                .UseUraniumUI()
                .UseUraniumUIMaterial()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        static MauiAppBuilder RegisterPages(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<HomePage>();
            builder.Services.AddSingleton<TestPage>();
            builder.Services.AddTransient<HomeViewModel>();
            builder.Services.AddTransient<TestViewModel>();

            return builder;
        }
    }
}
