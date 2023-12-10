using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyShop.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SesionLoginPage : ContentPage
    {
        public SesionLoginPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (Application.Current.Properties.ContainsKey("Usuario") && Application.Current.Properties.ContainsKey("Contrasenia"))
            {
                string usuario = (string)Application.Current.Properties["Usuario"];
                UsuarioLabel.Text = $"Hola, {usuario}";
                txtusuario.Text = usuario;
                txtusuario.IsEnabled = false;
                txtcontrasenia.Text = "";
            }
            else
            {
                DisplayAlert("Error detectado", "No se encuentra un usuario/contraseña en el sistema.", "Aceptar");
            }
        }

        private async void BtncancelarSL_Clicked(object sender, EventArgs e)
        {

            if (Application.Current.Properties.ContainsKey("Usuario"))
            {
                Application.Current.Properties.Remove("Usuario");
                Application.Current.Properties["Usuario"] = "Invitado";
                await Shell.Current.GoToAsync("//InicioPage");
            }


        }

        private async void BtniniciarsesionSL_Clicked(object sender, EventArgs e)
        {
            string usuarioSL = txtusuario.Text;
            string contraseniaSL = txtcontrasenia.Text;

            if (Application.Current.Properties.ContainsKey("Usuario") && Application.Current.Properties.ContainsKey("Contrasenia"))
            {
                string usuarioGuardado = Application.Current.Properties["Usuario"].ToString();
                string contraseniaGuardado = Application.Current.Properties["Contrasenia"].ToString();
                if (usuarioSL == usuarioGuardado && contraseniaSL == contraseniaGuardado)
                {
                    await Shell.Current.GoToAsync("//InicioPage");
                }
                else
                {
                    await DisplayAlert("Error detectado", "La contraseña no es correcta, intenta de nuevo.", "Aceptar");
                    txtcontrasenia.Text = "";
                    await Shell.Current.GoToAsync("//SesionLoginPage");
                }




                //string usuario = (string)Application.Current.Properties["Usuario"];
                //UsuarioLabel.Text = $"Hola, {usuario}";
                //txtusuario.Text = usuario;
                //txtusuario.IsEnabled = false;
            }
            else
            {
                await DisplayAlert("Error detectado", "No existen cuentas almacenadas en el sistema.", "Aceptar");
            }



        }
    }
}