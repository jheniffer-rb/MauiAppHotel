using MauiAppHotel.Models;
// Importação do namespace que contém os modelos de dados, incluindo `Hospedagem` e `Quarto`.

namespace MauiAppHotel.Views;
// Define o namespace para as visualizações da aplicação.

public partial class ContratacaoHospedagem : ContentPage
{
    App PropriedadesApp;
    // Declaração de uma variável que armazena uma referência à aplicação principal.
    // Usada para acessar dados globais, como a lista de quartos.

    public ContratacaoHospedagem()
    {
        InitializeComponent();
        // Inicializa os componentes da página, configurados no arquivo XAML correspondente.

        PropriedadesApp = (App)Application.Current;
        // Obtém uma instância da aplicação principal e a armazena na variável `PropriedadesApp`.

        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;
        // Configura a fonte de dados do `Picker` de quartos.
        // A lista de quartos é definida globalmente na aplicação.

        dtpck_checkin.MinimumDate = DateTime.Now;
        // Define a data mínima do `DatePicker` de check-in como a data atual.

        dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);
        // Define a data máxima do `DatePicker` de check-in para um mês à frente da data atual.

        dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
        // Define a data mínima do `DatePicker` de check-out como um dia após a data selecionada de check-in.

        dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);
        // Define a data máxima do `DatePicker` de check-out como seis meses após a data selecionada de check-in.
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        // Evento executado quando o botão "Avançar" é clicado.
        try
        {
            Hospedagem h = new Hospedagem
            {
                QuartoSelecionado = (Quarto)pck_quarto.SelectedItem,
                // Acomodação selecionada pelo usuário no `Picker`.

                QntAdultos = Convert.ToInt32(stp_adultos.Value),
                // Número de adultos selecionado no `Stepper`.

                QntCriancas = Convert.ToInt32(stp_criancas.Value),
                // Número de crianças selecionado no `Stepper`.

                DataCheckIn = dtpck_checkin.Date,
                // Data de check-in selecionada no `DatePicker`.

                DataCheckOut = dtpck_checkout.Date,
                // Data de check-out selecionada no `DatePicker`.
            };

            await Navigation.PushAsync(new HospedagemContratada()
            {
                BindingContext = h
                // Passa a instância `h` da hospedagem como o contexto de dados para a nova página.
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
        // Evento executado quando o usuário seleciona uma nova data de check-in.

        DatePicker elemento = sender as DatePicker;
        // Converte o remetente do evento para um `DatePicker`.

        DateTime data_selecionada_checkin = elemento.Date;
        // Obtém a nova data de check-in selecionada.

        dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        // Atualiza a data mínima de check-out para um dia após a nova data de check-in.

        dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);
        // Atualiza a data máxima de check-out para seis meses após a nova data de check-in.
    }
}
