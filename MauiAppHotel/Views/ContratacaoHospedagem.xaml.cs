using MauiAppHotel.Models;
// Importa��o do namespace que cont�m os modelos de dados, incluindo `Hospedagem` e `Quarto`.

namespace MauiAppHotel.Views;
// Define o namespace para as visualiza��es da aplica��o.

public partial class ContratacaoHospedagem : ContentPage
{
    App PropriedadesApp;
    // Declara��o de uma vari�vel que armazena uma refer�ncia � aplica��o principal.
    // Usada para acessar dados globais, como a lista de quartos.

    public ContratacaoHospedagem()
    {
        InitializeComponent();
        // Inicializa os componentes da p�gina, configurados no arquivo XAML correspondente.

        PropriedadesApp = (App)Application.Current;
        // Obt�m uma inst�ncia da aplica��o principal e a armazena na vari�vel `PropriedadesApp`.

        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;
        // Configura a fonte de dados do `Picker` de quartos.
        // A lista de quartos � definida globalmente na aplica��o.

        dtpck_checkin.MinimumDate = DateTime.Now;
        // Define a data m�nima do `DatePicker` de check-in como a data atual.

        dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);
        // Define a data m�xima do `DatePicker` de check-in para um m�s � frente da data atual.

        dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
        // Define a data m�nima do `DatePicker` de check-out como um dia ap�s a data selecionada de check-in.

        dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);
        // Define a data m�xima do `DatePicker` de check-out como seis meses ap�s a data selecionada de check-in.
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        // Evento executado quando o bot�o "Avan�ar" � clicado.
        try
        {
            Hospedagem h = new Hospedagem
            {
                QuartoSelecionado = (Quarto)pck_quarto.SelectedItem,
                // Acomoda��o selecionada pelo usu�rio no `Picker`.

                QntAdultos = Convert.ToInt32(stp_adultos.Value),
                // N�mero de adultos selecionado no `Stepper`.

                QntCriancas = Convert.ToInt32(stp_criancas.Value),
                // N�mero de crian�as selecionado no `Stepper`.

                DataCheckIn = dtpck_checkin.Date,
                // Data de check-in selecionada no `DatePicker`.

                DataCheckOut = dtpck_checkout.Date,
                // Data de check-out selecionada no `DatePicker`.
            };

            await Navigation.PushAsync(new HospedagemContratada()
            {
                BindingContext = h
                // Passa a inst�ncia `h` da hospedagem como o contexto de dados para a nova p�gina.
            });
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
            // Exibe uma mensagem de alerta caso ocorra um erro no processo.
        }
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        // Evento executado quando o usu�rio seleciona uma nova data de check-in.

        DatePicker elemento = sender as DatePicker;
        // Converte o remetente do evento para um `DatePicker`.

        DateTime data_selecionada_checkin = elemento.Date;
        // Obt�m a nova data de check-in selecionada.

        dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        // Atualiza a data m�nima de check-out para um dia ap�s a nova data de check-in.

        dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);
        // Atualiza a data m�xima de check-out para seis meses ap�s a nova data de check-in.
    }
}
