namespace MauiAppHotel.Views;

// Define o namespace da p�gina "HospedagemContratada".

public partial class HospedagemContratada : ContentPage
{
    // Declara��o da classe "HospedagemContratada", que herda de "ContentPage".
    // Esta classe est� vinculada � p�gina XAML correspondente.

    public HospedagemContratada()
    {
        InitializeComponent();
        // Inicializa os componentes definidos no arquivo XAML associado.
        // Este m�todo � gerado automaticamente pelo compilador e configura a interface da p�gina.
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        // Evento associado ao clique do bot�o "Voltar" no arquivo XAML.
        // � invocado quando o usu�rio clica no bot�o.

        Navigation.PopAsync();
        // Retorna para a p�gina anterior na pilha de navega��o.
        // "PopAsync" remove a p�gina atual da pilha de navega��o.
    }
}
