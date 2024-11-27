namespace MauiAppHotel
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)// Método que incrementa o contador de cliques
        {
            count++;

            if (count == 1)// Verifica se o contador é igual a 1
                CounterBtn.Text = $"Clicked {count} time";// Atualiza o texto do botão
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);// Anuncia o texto do botão
        }
    }

}