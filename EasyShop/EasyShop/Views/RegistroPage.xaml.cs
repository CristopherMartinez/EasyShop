using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyShop.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistroPage : ContentPage
    {
        public RegistroPage()
        {
            InitializeComponent();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();


            if (Application.Current.Properties.ContainsKey("Usuario") && Application.Current.Properties["Usuario"].ToString() == "Invitado")
            {
                etiq_bienv.IsVisible = true;
                string usuario1 = (string)Application.Current.Properties["Usuario"];
                etiq_logcomo.Text = $"Actualmente estás como: {usuario1}";
                etiq_logcomo.IsVisible = true;
                imgReg.IsVisible = true;
                txtusuario.IsVisible = true;
                txtcontrasenia.IsVisible = true;
                txtusuario.Text = "";
                txtcontrasenia.Text = "";
                frmusuario.IsVisible = true;
                frmcontrasenia.IsVisible = true;
                btningresar.IsVisible = true;
                btninvitado.IsVisible = true;
                btnregresarR.IsVisible = false;
                
            }
            else
            {
                if (Application.Current.Properties.ContainsKey("Usuario") && Application.Current.Properties["Usuario"] != null && Application.Current.Properties["Usuario"].ToString() != "Invitado")
                {
                    string usuario2 = (string)Application.Current.Properties["Usuario"];
                    etiq_bienv.IsVisible = false;
                    etiq_logcomo.IsVisible = true;
                    etiq_logcomo.Text = $"Estas logueado como, {usuario2}";
                    txtusuario.IsVisible = false;
                    txtcontrasenia.IsVisible = false;
                    frmusuario.IsVisible = false;
                    frmcontrasenia.IsVisible = false;
                    btningresar.IsVisible = false;
                    btninvitado.IsVisible = false;
                    btncrearcuenta.IsVisible = false;
                    btncontinvitado.IsVisible = false;
                    btnregresarR.IsVisible = true;
                }
                else
                {
                    etiq_logcomo.Text = "Actualmente no hay un usuario válido en el sistema.";
                    etiq_logcomo.IsVisible = true;
                }
            }
        }

        async void Btninvitado_Clicked(object sender, EventArgs e)
        {

            string usuario = "Invitado";
            Application.Current.Properties["Usuario"] = usuario;

            await Shell.Current.GoToAsync("//InicioPage");

        }

        private async void Btnregistrar_Clicked(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string contrasenia = txtcontrasenia.Text;

            if (!string.IsNullOrEmpty(txtusuario.Text) && !string.IsNullOrEmpty(txtcontrasenia.Text))
            {
                if (CorreoValido(usuario))
                {
                    if (contrasenia.Length < 5)
                    {
                        await DisplayAlert("Error detectado", "La contraseña debe tener mínimo 5 caracteres alfanuméricos, intenta de nuevo.", "Aceptar");
                    }
                    else
                    {
                        if (!string.IsNullOrWhiteSpace(contrasenia) && !contrasenia.Contains(" ") && !contrasenia.All(char.IsLetterOrDigit))
                        {
                            Application.Current.Properties["Usuario"] = usuario;
                            Application.Current.Properties["Contrasenia"] = contrasenia;

                            await Shell.Current.GoToAsync("//SesionLoginPage");
                            //await Shell.Current.GoToAsync("//InicioPage");ORIGINAL
                        }
                        else
                        {
                            await DisplayAlert("Error detectado", "La contraseña no debe tener espacios en blanco, debe ser alfanumérica y debe contener un caracter especial como mínimo, intenta de nuevo.", "Aceptar");

                        }
                    }
                }
                else
                {
                    await DisplayAlert("Validación fallida", "El correo electrónico no es válido, intenta de nuevo.", "Aceptar");
                }
            }
            else
            {
                await DisplayAlert("Error detectado", "Se detectan campos vacíos, llena ambos campos.", "Aceptar");
            }
        }
        //método IsValidEmail que utiliza una expresión regular para verificar si el texto ingresado en el Entry es un correo electrónico válido.
        bool CorreoValido(string email)
        {
            // Expresión regular para validar el correo electrónico.
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Comprueba si el correo electrónico coincide con el patrón.
            return Regex.IsMatch(email, emailPattern);
        }

        private async void Btncontinvitado_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//InicioPage");
        }

        private async void BtnregresarR_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//InicioPage");
        }
    }
}