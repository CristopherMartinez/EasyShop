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
    public partial class Ticket : ContentPage
    {
        public Ticket()
        {
            InitializeComponent();
            BindingContext = new TicketViewModel();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("COMPRA", "Está seguro de realizar la compra", "OK", "Cancelar");

            if (result)
            {
                CarritoComprasViewModel carrito = new CarritoComprasViewModel();
                carrito.LimpiarCarrito();

                // Navega hacia atrás a la pagina de productos
                await Shell.Current.GoToAsync("//Productos");

            }
        }

    }
}