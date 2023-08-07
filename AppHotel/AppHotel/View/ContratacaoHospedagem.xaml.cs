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
        public ContratacaoHospedagem()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            PropriedadesApp
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