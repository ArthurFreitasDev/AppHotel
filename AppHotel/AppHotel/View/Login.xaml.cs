using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppHotel.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        App PropriedadesApp;
        public Login()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            PropriedadesApp = (App)Application.Current;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string Usuario = txt_Usuario.Text;
            string Senha = txt_Senha.Text;

            string Usuario_Correto = "aluno";
            string Senha_Correta = "etec";

            if (Usuario == Usuario_Correto && Senha == Senha_Correta)
            {
                App.Current.Properties.Add("Usuario_Logado", Usuario);
                App.Current.MainPage = new ContratacaoHospedagem();
            }
            else
            {
                DisplayAlert("Ops", "Usuario ou senha incorretos.", "OK");
            }
        }
    }
}