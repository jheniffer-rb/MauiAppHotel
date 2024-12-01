using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application// Classe principal da aplicação
    {
        public List<Quarto> lista_quartos = new List<Quarto>// Lista de quartos disponíveis no hotel
        {
            new Quarto() // Quarto de categoria "Suíte Super Luxo"
            {
                Descricao = "Suíte Super Luxo", // Descrição do quarto
                ValorDiariaAdulto = 110.0, // Valor da diária para adultos
                ValorDiariaCrianca = 55.0 // Valor da diária para crianças
          
            },
            new Quarto()// Quarto de categoria "Suíte Luxo"
            {
                Descricao = "Suíte Luxo", // Descrição do quarto
                ValorDiariaAdulto = 80.0, // Valor da diária para adultos
                ValorDiariaCrianca = 40.0 // Valor da diária para crianças
            },
            new Quarto() // Quarto de categoria "Suíte Single"
            {
                Descricao = "Suíte Single", // Descrição do quarto
                ValorDiariaAdulto = 50.0, // Valor da diária para adultos
                ValorDiariaCrianca = 25.0 // Valor da diária para crianças
            },
            new Quarto() // Quarto de categoria "Suíte Crise"
            {
                Descricao = "Suíte Crise", // Descrição do quarto
                ValorDiariaAdulto = 25,// Valor da diária para adultos
                ValorDiariaCrianca = 12.5// Valor da diária para crianças
            }
        };

        // Construtor da classe App.
        public App()
        {
            InitializeComponent(); // Inicializa os componentes da aplicação definidos no arquivo XAML.

            // Define a página inicial do aplicativo como ContratacaoHospedagem, encapsulada em uma NavigationPage.
            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        // Método sobrescrito para criar a janela principal da aplicação com dimensões personalizadas.
        protected override Window CreateWindow(IActivationState? activationState)
        {
            // Cria uma instância da janela base.
            var window = base.CreateWindow(activationState);

            // Define a largura e altura da janela.
            window.Width = 400; // Largura da janela em pixels.
            window.Height = 600; // Altura da janela em pixels.

            return window; // Retorna a janela configurada.
        }
    }// Fim da classe App.
}// Fim do namespace MauiAppHotel.