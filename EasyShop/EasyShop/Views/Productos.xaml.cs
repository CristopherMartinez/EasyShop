using EasyShop.Models;
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
    public partial class Productos : ContentPage
    {
        public Productos()
        {
            InitializeComponent();
            BindingContext = new ProductosViewModel();
        }

        async void ImageButton_Clicked(object sender, EventArgs e)
        {
            // Obtiene el ImageButton que se hizo clic
            ImageButton clickedButton = (ImageButton)sender;

            //Obtenemos la categoria
            Categoria categoria = (Categoria)clickedButton.BindingContext;

            if (categoria != null)
            {
                // Accedemos a las propiedades
                string nombre = categoria.nombre;
                string id = categoria.id;


                //Redirigimos a la pagina segun el id
                if (id == "catHerramienta")
                {
                    //Mandar a la pagina de Categoria de Herramientas
                    await Shell.Current.GoToAsync($"{nameof(Herramientas)}");

                }
                else if (id == "catVerdura")
                {
                    //Mandar a la pagina de Categoria de Verduras
                    await Shell.Current.GoToAsync($"{nameof(Verduras)}");
                }
                else if (id == "catJuguete")
                {
                    //Mandar a la pagina de Categoria de Juguetes
                    await Shell.Current.GoToAsync($"{nameof(Juguetes)}");

                }
                else if (id == "catPersonal")
                {
                    //Mandar a la pagina de Categoria de Aseo personal
                    await Shell.Current.GoToAsync($"{nameof(Personal)}");

                }
                else if(id == "catHogar")
                {
                    //Mandar a la pagina de Categoria de Juguetes
                    await Shell.Current.GoToAsync($"{nameof(Hogar)}");

                }
                //await Shell.Current.GoToAsync($"{nameof(PlantillaProductos)}?{nameof(PlantillaProductosViewModel.ItemId)}={id}");



            }
        }

    }
}