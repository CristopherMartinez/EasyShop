using EasyShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace EasyShop.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarritoCompras : ContentPage
    {
      /*  private ToolbarItem contadorToolbarItem; *///Almacenamos el toolBarItem del contador
        public CarritoCompras()
        {
            InitializeComponent();
            BindingContext = new CarritoComprasViewModel();
            //contadorToolbarItem = (ToolbarItem)ToolbarItems[1];
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
                Shell.Current.GoToAsync($"{nameof(Ticket)}");
 
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            CarritoComprasViewModel carrito = new CarritoComprasViewModel();
            bool result = await DisplayAlert("CARRITO", "Está seguro de vaciar", "OK", "Cancelar");

            if (result)
            {
                carrito.LimpiarCarrito();

                await Shell.Current.GoToAsync("//Productos");
            }
        }




    }
}