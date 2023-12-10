using EasyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;
using Newtonsoft.Json;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace EasyShop.ViewModels
{
    public class CarritoComprasViewModel: INotifyPropertyChanged
    {

        public string AvisoCarritoVacio {  get; set; }

        private const string CarritoKey = "CarritoKey";

        public List<Producto> items { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public bool botonPagar {  get; set; }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int contador { get; set; }

        public int Contador
        {
            get { return contador; }
            set
            {
                if (contador != value)
                {
                    contador = value;
                    OnPropertyChanged(nameof(Contador));
                }
            }
        }

        public CarritoComprasViewModel()
        {
            RevisarCarrito();

        }

        public List<Producto> ObtenerCarrito()
        {
            if (Preferences.ContainsKey(CarritoKey))
            {
                var carrito = Preferences.Get(CarritoKey, string.Empty);
                return JsonConvert.DeserializeObject<List<Producto>>(carrito);
            }

            return new List<Producto>();
        }

        ////Correcto
        public void AgregarAlCarrito(Producto producto)
        {
            var carrito = ObtenerCarrito();
            carrito.Add(producto);


            var car = JsonConvert.SerializeObject(carrito);
            Preferences.Set(CarritoKey, car);

            //
            Contador++;
        }

       

        public void AgregarAlCarritoCorr(Producto producto, int cantidad)
        {
            var carrito = ObtenerCarrito();

            // Verificar si el producto ya está en el carrito
            var productoEnCarrito = carrito.FirstOrDefault(p => p.id == producto.id);

            if (productoEnCarrito != null)
            {
                // Si el producto ya está en el carrito, aumenta la cantidad en lugar de agregarlo nuevamente
                productoEnCarrito.cantidadDisponible += cantidad;
            }
            else
            {
                // Si el producto no está en el carrito, agrégalo con la cantidad especificada
                producto.cantidadDisponible = cantidad;
                carrito.Add(producto);
            }

            var car = JsonConvert.SerializeObject(carrito);
            Preferences.Set(CarritoKey, car);

            
            Contador++;
        }

        public int obtenerCantidad()
        {
            List<Producto> lista = ObtenerCarrito();
            int cantidadElementos = lista.Count;
            return cantidadElementos;
        }



        public void LimpiarCarrito()
        {
            Preferences.Remove(CarritoKey);
           
        }

        public List<Producto> ObtenerCarritoAgrupadoPorNombre()
        {
            if (Preferences.ContainsKey(CarritoKey))
            {
                var carritoSerializado = Preferences.Get(CarritoKey, string.Empty);
                var herramientasEnCarrito = JsonConvert.DeserializeObject<List<Producto>>(carritoSerializado);

                // Filtrar las herramientas que están en el carrito
                var herramientasCompradas = herramientasEnCarrito
                    .Where(h => h.cantidadDisponible > 0)
                    .ToList();

                // Utilizamos LINQ para agrupar y sumar la cantidad
                var herramientasAgrupadas = herramientasCompradas
                    .GroupBy(h => h.nombre)
                    .Select(herr => new Producto
                    {
                        nombre = herr.Key,
                        imagen = herr.First().imagen,
                        cantidadDisponible = herr.Sum(h => (h.cantidadDisponible / herr.First().cantidadDisponible)),
                        precio = herr.First().precio * herr.Sum(h => (h.cantidadDisponible / herr.First().cantidadDisponible))

                    })
                    .ToList();

                return herramientasAgrupadas;
            }

            return new List<Producto>();
        }






        public void RevisarCarrito()
        {
            if (Preferences.ContainsKey(CarritoKey))
            {
                //Correcto
                //items = ObtenerCarritoAgrupadoPorNombre();
                items = ObtenerCarrito();
                botonPagar = true;
            }
            else
            {
                AvisoCarritoVacio = "No hay elementos en el carrito";
                botonPagar = false;

            }
        }

        ////Metodo para eliminar del carrito por id
        //public void eliminarPorId(string id)
        //{


        //}

    }
}