using EasyShop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace EasyShop.ViewModels
{
    public class HerramientasViewModel:CarritoComprasViewModel
    {
        public ObservableCollection<Producto> Herramientas { get; set; }

        //public int Contador { get; set; }

      
        CarritoComprasViewModel carrito = new CarritoComprasViewModel();
        
        public HerramientasViewModel()
        {
            Contador = carrito.obtenerCantidad();

            Herramientas = new ObservableCollection<Producto>
            {
                new Producto
                {
                    id = "herr1",
                    nombre = "Alicate",
                    precio = 400,
                    descripcion = "alicate de uso rudo",
                    cantidadDisponible = 18,
                    imagen = "alicate.png"
                },
                new Producto
                {
                    id = "herr2",
                    nombre = "Brocha",
                    precio = 50,
                    descripcion = "Brocha para pintura de aceite",
                    cantidadDisponible = 30,
                    imagen = "brocha.png"
                },
                new Producto
                {
                    id = "herr3",
                    nombre = "Martillo",
                    precio = 200,
                    descripcion = "Martillo de uso rudo",
                    cantidadDisponible = 15,
                    imagen = "martillo.png"
                },
                new Producto
                {
                    id = "herr4",
                    nombre = "Nivel",
                    precio = 250,
                    descripcion = "Para uso profesional",
                    cantidadDisponible = 22,
                    imagen = "nivelmano.png"
                },
                new Producto
                {
                    id = "herr5",
                    nombre = "Pala",
                    precio = 200,
                    descripcion = "Pala de uso rudo",
                    cantidadDisponible = 12,
                    imagen = "pala.png"
                },
                new Producto
                {
                    id = "herr6",
                    nombre = "Sierra",
                    precio = 300,
                    descripcion = "Sierra color cafe claro",
                    cantidadDisponible = 20,
                    imagen = "sierra.png"
                },


            };
        }

     


    }
}