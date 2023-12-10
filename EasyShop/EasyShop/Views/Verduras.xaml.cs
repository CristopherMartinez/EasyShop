using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyShop.Models;
using EasyShop.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyShop.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Verduras : ContentPage
    {
        private ToolbarItem contadorToolbarItem; //Almacenamos el toolBarItem del contador
        public Verduras()
        {
            InitializeComponent();
            BindingContext = new VerdurasViewModel();

            contadorToolbarItem = (ToolbarItem)ToolbarItems[1]; // Obtiene la referencia al ToolbarItem del contador
        }


        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    if (sender is Button button)
        //    {
        //        var herramientas = button.BindingContext as Producto;

        //        if (herramientas != null && herramientas.Cantidad > 0)
        //        {
        //            CarritoComprasViewModel carrito = new CarritoComprasViewModel();
        //            carrito.AgregarAlCarritoCorr(herramientas, herramientas.Cantidad);
        //            contadorToolbarItem.Text = carrito.obtenerCantidad().ToString(); // Actualiza el contador
        //            DisplayAlert("Correcto", "Agregado al carrito", "OK");
        //        }
        //        else
        //        {
        //            // Aquí puedes mostrar un mensaje de error si la cantidad es igual o menor a 0.
        //            DisplayAlert("Error", "La cantidad debe ser mayor a 0", "OK");
        //        }
        //    }
        //}

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                var herramientas = button.BindingContext as Producto;

                if (herramientas != null)
                {
                    CarritoComprasViewModel carrito = new CarritoComprasViewModel();

                    // Verificar que la cantidad sea mayor que cero
                    if (herramientas.Cantidad > 0)
                    {
                        // Verificar que la cantidad no sea mayor que la cantidadDisponible
                        if (herramientas.Cantidad <= herramientas.cantidadDisponible)
                        {
                            carrito.AgregarAlCarritoCorr(herramientas, herramientas.Cantidad);
                            contadorToolbarItem.Text = carrito.obtenerCantidad().ToString(); // Actualiza el contador
                            DisplayAlert("Correcto", "Agregado al carrito", "OK");
                        }
                        else
                        {
                            DisplayAlert("Error", "La cantidad seleccionada supera la cantidad disponible", "OK");
                        }
                    }
                    else
                    {
                        DisplayAlert("Error", "La cantidad debe ser mayor a 0", "OK");
                    }
                }
            }
        }



        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

            //Ir a pagina de carrito de compras
            Shell.Current.GoToAsync($"{nameof(CarritoCompras)}");
        }


    }
}