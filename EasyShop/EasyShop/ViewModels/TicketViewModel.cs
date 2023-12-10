using EasyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace EasyShop.ViewModels
{
    public class TicketViewModel:CarritoComprasViewModel   
    {
        public List<Producto> itemsTicket { get; set; }

        public float TotalAPagar {  get; set; }
        public TicketViewModel()
        {
            itemsTicket = items;
            TotalAPagar = CalcularTotal();
        }

        public float CalcularTotal()
        {
            float total = 0.0f;

            if (itemsTicket != null && itemsTicket.Any())
            {
                total = itemsTicket.Sum(item => item.cantidadDisponible * item.precio);
            }

            return total;
        }

    }
}