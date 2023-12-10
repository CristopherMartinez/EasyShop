using EasyShop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace EasyShop.ViewModels
{
    public class JuguetesViewModel: CarritoComprasViewModel 
    {
        public ObservableCollection<Producto> Juguetes { get; set; }

        //public int Contador { get; set; }


        CarritoComprasViewModel carrito = new CarritoComprasViewModel();

        public JuguetesViewModel()
        {

            Contador = carrito.obtenerCantidad();

            Juguetes = new ObservableCollection<Producto>
            {
                new Producto
                {
                    id = "juguet1",
                    nombre = "Barbie",
                    precio = 400,
                    descripcion = "Barbie edición especial",
                    cantidadDisponible = 18,
                    imagen = "barbie.png"
                },
                new Producto
                {
                    id = "juguet2",
                    nombre = "Bowling",
                    precio = 50,
                    descripcion = "De plastico",
                    cantidadDisponible = 30,
                    imagen = "Bowling.png"
                },
                new Producto
                {
                    id = "juguet3",
                    nombre = "Coche",
                    precio = 200,
                    descripcion = "Edicion especial",
                    cantidadDisponible = 15,
                    imagen = "coche.png"
                },
                new Producto
                {
                    id = "juguet4",
                    nombre = "Cubo",
                    precio = 125,
                    descripcion = "Para uso profesional",
                    cantidadDisponible = 22,
                    imagen = "cubo.png"
                },
                new Producto
                {
                    id = "juguet5",
                    nombre = "Pelota",
                    precio = 80,
                    descripcion = "Pelota para divertirse",
                    cantidadDisponible = 12,
                    imagen = "pelota.png"
                },
                new Producto
                {
                    id = "juguet6",
                    nombre = "Tren",
                    precio = 300,
                    descripcion = "Tren edición especial",
                    cantidadDisponible = 20,
                    imagen = "tren.png"
                },


            };

        }
    }
}