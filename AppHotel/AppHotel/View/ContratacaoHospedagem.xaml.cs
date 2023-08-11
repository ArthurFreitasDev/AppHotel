using System;
using AppHotel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppHotel.Model;

namespace AppHotel.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContratacaoHospedagem : ContentPage
    {
        App PropriedadesApp;
        public ContratacaoHospedagem()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            PropriedadesApp = (App) Application.Current;

            lbl_Usuario.Text = App.Current.Properties["Usuario_Logado"].ToString();

            pck_Suite.ItemsSource = PropriedadesApp.Lista_Suites;

            dtpck_Checkin.MinimumDate = DateTime.Now;
            dtpck_Checkin.MinimumDate = DateTime.Now.AddMonths(6);

            dtpck_CheckOut.MinimumDate = DateTime.Now.AddDays(1);
            dtpck_CheckOut.MaximumDate = DateTime.Now.AddMonths(6).AddDays(1);
        }

        private void dtpck_Checkin_DateSelected(object sender, DateChangedEventArgs e)
        {
            DatePicker elemento = (DatePicker)sender;

            dtpck_CheckOut.MinimumDate = elemento.Date.AddDays(1);
            dtpck_CheckOut.MaximumDate = elemento.Date.AddMonths(6).AddDays(1);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new NavigationPage(new HospedagemCalculada())
                {
                    BindingContext = new Hospedagem()
                    {
                        QntAdultos = Convert.ToInt32(lbl_qnt_Adultos.Text),
                        QntCriancas = Convert.ToInt32(lbl_qnt_Criancas.Text),
                        QuartoEscolhido = (Suite)pck_Suite.SelectedItem,
                        DataCheckIn = dtpck_Checkin.Date,
                        DataCheckOut = dtpck_CheckOut.Date
                    }
                };
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            bool confime = await DisplayAlert("Tem Certeza?",
                                              "Desconecter sua conta?",
                                              "Sim", "Não");

            if (confime)
            {
                App.Current.Properties.Remove("usuario_logado");
                App.Current.MainPage = new Login();
            }
        }
    }
}