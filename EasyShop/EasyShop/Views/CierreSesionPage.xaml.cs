using EasyShop.ViewModels;
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
    public partial class CierreSesionPage : ContentPage
    {
        public CierreSesionPage()
        {
            InitializeComponent();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();


            if (Application.Current.Properties.ContainsKey("Usuario") && Application.Current.Properties["Usuario"].ToString() == "Invitado")
            {

                txtfecha.IsVisible = false;
                txthora.IsVisible = false;
                frmfecha.IsVisible = false;
                frmhora.IsVisible = false;
                etiq_bienv.IsVisible = false;
                etiq_logcomoC.IsVisible = true;
                btncerrars.IsVisible = false;
                btncancelar.IsVisible = false;
                btnregresarC.IsVisible = true;

            }
            else
            {
                if (Application.Current.Properties.ContainsKey("Usuario") && Application.Current.Properties["Usuario"].ToString() != "Invitado")
                {
                    txtfecha.Text = "Fecha: " + DateTime.Now.ToString("MM-dd-yy");
                    txthora.Text = "Hora: " + DateTime.Now.ToString("HH:mm");
                    txtfecha.IsVisible = true;
                    txtfecha.TextColor = Color.Black;
                    txthora.IsVisible = true;
                    txthora.TextColor = Color.Black;
                    frmfecha.IsVisible = true;
                    frmhora.IsVisible = true;
                    etiq_bienv.IsVisible = true;
                    etiq_logcomoC.IsVisible = false;
                    btncerrars.IsVisible = true;
                    btncancelar.IsVisible = true;
                    btnregresarC.IsVisible = false;

                }
            }
        }

        private async void BtncerrarSN_Clicked(object sender, EventArgs e)
        {

            if (Application.Current.Properties.ContainsKey("Usuario"))
            {
                //-----------------------------------------MICODIGO------------------------------------------
                //Creo una instancia del ViewModel de CarritoCompras
                var carritoViewModel = new CarritoComprasViewModel();
                //Llamo al método LimpiarCarrito
                carritoViewModel.LimpiarCarrito();
                //-----------------------------------------MICODIGO------------------------------------------

                Application.Current.Properties.Remove("Usuario");
                await Shell.Current.GoToAsync("//InicioPage");

            }
            else
            {
                await Shell.Current.GoToAsync("//InicioPage");
            }
        }

        private async void BtncancelarC_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//InicioPage");
        }

        private async void BtnregresarC_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//InicioPage");
        }
    }
}