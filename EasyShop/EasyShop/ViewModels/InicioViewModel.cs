using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Text;

namespace EasyShop.ViewModels
{
    public class InicioViewModel
    {
        public InicioViewModel()
        {
            ColorAcentuacionI = Color.FromHex("F7F4FB");
            EtiqBienvenidoI = Color.FromHex("845EC2");
            TextoBienvenivoI = "Bienvenido a";
        }

        public Color ColorAcentuacionI { get; private set; }
        public Color EtiqBienvenidoI { get; private set; }
        public string TextoBienvenivoI { get; private set; }
    }
}
