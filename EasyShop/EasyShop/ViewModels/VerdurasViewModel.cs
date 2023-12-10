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
    public class VerdurasViewModel : CarritoComprasViewModel
    {
        public ObservableCollection<Producto> Verduras { get; set; }

        CarritoComprasViewModel carrito = new CarritoComprasViewModel();

        public VerdurasViewModel()
        {
            Contador = carrito.obtenerCantidad();

            Verduras = new ObservableCollection<Producto>
            {
                new Producto
                {
                    id = "verd1",
                    nombre = "Aguacate",
                    precio = 10,
                    descripcion = "aguacate has",
                    cantidadDisponible = 55,
                    imagen = "aguacate.png"
                },
                new Producto
                {
                    id = "verd2",
                    nombre = "Tomate",
                    precio = 8,
                    descripcion = "Jitomate con vitamina C",
                    cantidadDisponible = 30,
                    imagen = "tomate.png"
                },
                new Producto
                {
                    id = "verd3",
                    nombre = "Papa",
                    precio = 5,
                    descripcion = "Patata fresca",
                    cantidadDisponible = 15,
                    imagen = "patata.png"
                },
                new Producto
                {
                    id = "verd4",
                    nombre = "Zanahoria",
                    precio = 250,
                    descripcion = "Zanahoria fresca",
                    cantidadDisponible = 22,
                    imagen = "zanahoria.png"
                },
                new Producto
                {
                    id = "verd5",
                    nombre = "Cebolla",
                    precio = 7,
                    descripcion = "Cebolla blanca",
                    cantidadDisponible = 12,
                    imagen = "cebolla.png"
                },
                new Producto
                {
                    id = "verd6",
                    nombre = "Lechuga",
                    precio = 20,
                    descripcion = "Lechuga romana",
                    cantidadDisponible = 50,
                    imagen = "lechuga.png"
                },


            };

        }
    }
}