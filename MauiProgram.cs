using Microsoft.Extensions.Logging;

namespace RentACar_Mobile_
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
                })

            .ConfigureEssentials(essentials =>
             {
                 essentials.UseMapServiceToken("Akd-sGjriQ27P0AhEH5pBel2EXhdvyoGRRIH460isJVK2_wu-Jcovo1nGLPCeUy0");
             });
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}