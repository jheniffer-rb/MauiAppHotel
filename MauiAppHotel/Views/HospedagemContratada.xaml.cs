namespace MauiAppHotel.Views;

// Define o namespace da página "HospedagemContratada".

public partial class HospedagemContratada : ContentPage
{
    // Declaração da classe "HospedagemContratada", que herda de "ContentPage".
    // Esta classe está vinculada à página XAML correspondente.

    public HospedagemContratada()
    {
        InitializeComponent();
        // Inicializa os componentes definidos no arquivo XAML associado.
        // Este método é gerado automaticamente pelo compilador e configura a interface da página.
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        // Evento associado ao clique do botão "Voltar" no arquivo XAML.
        // É invocado quando o usuário clica no botão.

        Navigation.PopAsync();
        // Retorna para a página anterior na pilha de navegação.
        // "PopAsync" remove a página atual da pilha de navegação.
    }
}
