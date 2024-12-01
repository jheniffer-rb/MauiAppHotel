using Microsoft.Extensions.Logging;

namespace MauiAppHotel // Define o namespace MauiAppHotel
{
    public static class MauiProgram // Classe que define o programa Maui
    {
        public static MauiApp CreateMauiApp()// Método que cria a aplicação Maui
        {
            var builder = MauiApp.CreateBuilder(); // Cria um novo MauiAppBuilder e o armazena na variável "builder".
            builder
                .UseMauiApp<App>() // Define a aplicação principal como a classe "App".
                .ConfigureFonts(fonts => // Configura as fontes usadas na aplicação.
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");// Adiciona a fonte "OpenSans-Regular.ttf" com o nome "OpenSansRegular".
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");// Adiciona a fonte "OpenSans-Semibold.ttf" com o nome "OpenSansSemibold".
                    fonts.AddFont("Kalam-Bold.ttf", "KalamBold");// Adiciona a fonte "Kalam-Bold.ttf" com o nome "KalamBold".
                    fonts.AddFont("Kalam-Light.ttf", "KalamLight");// Adiciona a fonte "Kalam-Light.ttf" com o nome "KalamLight".
                    fonts.AddFont("Kalam-Regular.ttf", "Kalam");// Adiciona a fonte "Kalam-Regular.ttf" com o nome "Kalam".
                });

#if DEBUG // Verifica se o aplicativo está em modo de depuração
    		builder.Logging.AddDebug();// Adiciona a saída de log de depuração
#endif// Fim da verificação de modo de depuração

            return builder.Build();// Constrói a aplicação Maui e a retorna
        }
    }
}