using EasyShop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace EasyShop.ViewModels
{
    public class ProductosViewModel : BaseViewModel
    {
        //Creamos un coleccion de categorias
        private ObservableCollection<Categoria> categorias;
        public ObservableCollection<Categoria> Categorias
        {
            get { return categorias; }
            set
            {
                categorias = value;
                OnPropertyChanged(nameof(Categorias));
            }
        }

   

        public ProductosViewModel()
        {
            //Definimos la coleccion
            categorias = new ObservableCollection<Categoria>
             {
                 new Categoria
                 {
                     id = "catHerramienta",
                     nombre = "Herramientas",
                     imagen = "Herramientas.png"
                 },
                 new Categoria
                 {
                     id = "catHogar",
                     nombre = "Hogar",
                      imagen = "Hogar.png"

                 },
                 new Categoria
                 {
                     id = "catJuguete",
                     nombre = "Juguetes",
                     imagen = "Juguetes.png"
                 },
                  new Categoria
                 {
                     id = "catPersonal",
                     nombre = "Aseo Personal",
                     imagen = "Personal.png"
                 },
                   new Categoria
                 {
                     id = "catVerdura",
                     nombre = "Verduras",
                     imagen = "Verduras.png"
                 }
             };

            
        }

        

    }
}