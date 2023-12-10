using EasyShop.Models;
using EasyShop.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace EasyShop.ViewModels
{
    public class HogarViewModel: CarritoComprasViewModel
    {
        public ObservableCollection<Producto> Hogar { get; set; }

        //public int Contador { get; set; }


        CarritoComprasViewModel carrito = new CarritoComprasViewModel();

        public HogarViewModel()
        {
            Contador = carrito.obtenerCantidad();

            Hogar = new ObservableCollection<Producto>
            {
                new Producto
                {
                    id = "hogar1",
                    nombre = "Aspiradora",
                    precio = 800,
                    descripcion = "Aspiradora alto rendimiento",
                    cantidadDisponible = 18,
                    imagen = "aspiradora.png"
                },
                new Producto
                {
                    id = "hogar2",
                    nombre = "Plancha",
                    precio = 50,
                    descripcion = "De alto desempeño",
                    cantidadDisponible = 30,
                    imagen = "plancha.png"
                },
                new Producto
                {
                    id = "hogar3",
                    nombre = "Refrigerador",
                    precio = 8000,
                    descripcion = "Color Gris",
                    cantidadDisponible = 15,
                    imagen = "refrigerador.png"
                },
                new Producto
                {
                    id = "hogar4",
                    nombre = "Lavadora",
                    precio = 5000,
                    descripcion = "Para uso profesional",
                    cantidadDisponible = 22,
                    imagen = "lavadora.png"
                },
                new Producto
                {
                    id = "hogar5",
                    nombre = "Secadora",
                    precio = 500,
                    descripcion = "Alto desempeño",
                    cantidadDisponible = 12,
                    imagen = "secadora.png"
                },
                new Producto
                {
                    id = "hogar6",
                    nombre = "Taza",
                    precio = 300,
                    descripcion = "Tren edición especial",
                    cantidadDisponible = 20,
                    imagen = "taza.png"
                },


            };

        }
    }
}