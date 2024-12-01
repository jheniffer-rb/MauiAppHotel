using MauiAppHotel;

namespace MauiAppHotel
{
    public partial class MainPage : ContentPage // Define a classe MainPage que herda de ContentPage
    {
        int count = 0; // Declaração de uma variável inteira "count" inicializada com o valor 0

        public MainPage() // Construtor da classe MainPage
        {
            InitializeComponent(); // Inicializa os componentes da página definidos no arquivo XAML
        }

        private void OnCounterClicked(object sender, EventArgs e) // Método chamado quando o botão é clicado
        {
            count++; // Incrementa o contador

            if (count == 1) // Verifica se o contador é igual a 1
                CounterBtn.Text = $"Clicked {count} time"; // Atualiza o texto do botão
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text); // Anuncia o texto do botão
        }
    }
}
