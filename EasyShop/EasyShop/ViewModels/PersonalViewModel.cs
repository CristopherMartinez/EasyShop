using EasyShop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace EasyShop.ViewModels
{
    public class PersonalViewModel: CarritoComprasViewModel
    {
        public ObservableCollection<Producto> Personal { get; set; }

        //public int Contador { get; set; }


        CarritoComprasViewModel carrito = new CarritoComprasViewModel();
        public PersonalViewModel()
        {
            Contador = carrito.obtenerCantidad();

            Personal = new ObservableCollection<Producto>
            {
                new Producto
                {
                    id = "pers1",
                    nombre = "Afeitadora",
                    precio = 800,
                    descripcion = "Color gris",
                    cantidadDisponible = 18,
                    imagen = "afeitadora.png"
                },
                new Producto
                {
                    id = "pers2",
                    nombre = "Shampoo",
                    precio = 50,
                    descripcion = "Contra caida",
                    cantidadDisponible = 30,
                    imagen = "shampoo.png"
                },
                new Producto
                {
                    id = "pers3",
                    nombre = "Cortadora",
                    precio = 500,
                    descripcion = "De alto rendimiento",
                    cantidadDisponible = 15,
                    imagen = "cortadora.png"
                },
                new Producto
                {
                    id = "pers4",
                    nombre = "Jabon",
                    precio = 20,
                    descripcion = "Jabon hidratante",
                    cantidadDisponible = 22,
                    imagen = "jabon.png"
                },
                new Producto
                {
                    id = "pers5",
                    nombre = "Cepillo de Dientes",
                    precio = 500,
                    descripcion = "No daña dientes",
                    cantidadDisponible = 12,
                    imagen = "cepillodientes.png"
                },
                new Producto
                {
                    id = "pers6",
                    nombre = "Pasta dental",
                    precio = 300,
                    descripcion = "Sabor a menta",
                    cantidadDisponible = 20,
                    imagen = "pastadedientes.png"
                },


            };

        }
    }
}