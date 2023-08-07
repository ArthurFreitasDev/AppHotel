using System;
using AppHotel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}