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
    public partial class InicioPage : ContentPage
    {
        public InicioPage()
        {
            InitializeComponent();

            // Recupera el nombre de usuario de las propiedades de la aplicación
            //if (Application.Current.Properties.ContainsKey("Usuario"))
            //{
            //    string usuario = (string)Application.Current.Properties["Usuario"];
            //    UsuarioLabel.Text = $"Bienvenido, {usuario}";
            //}

            //UsuarioLabel.Text = $"Hola, Invitado1";
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Recupera el nombre de usuario de las propiedades de la aplicación
            if (Application.Current.Properties.ContainsKey("Usuario"))
            {
                string usuario = (string)Application.Current.Properties["Usuario"];
                UsuarioLabel.Text = $"Hola, {usuario}";
            }
            else
            {
                Application.Current.Properties.Remove("Usuario");
                Application.Current.Properties["Usuario"] = "Invitado";
                string usuario2 = (string)Application.Current.Properties["Usuario"];
                UsuarioLabel.Text = $"Hola, {usuario2}";
            }
        }

    }
}