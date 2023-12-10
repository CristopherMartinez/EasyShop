using System;
using System.Collections.Generic;
using System.Text;

namespace EasyShop.Models
{
    public class Personal
    {

        //Quiere decir productos de Aseo personal , NO personal de personas
        public string id { get; set; }
        public string nombre { get; set; }
        public float precio { get; set; }
        public string descripcion { get; set; }
        public int cantidadDisponible { get; set; }

    }
}
