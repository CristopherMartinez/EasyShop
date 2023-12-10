using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Text;
using EasyShop.Views;

namespace EasyShop.ViewModels
{
    public class RegistroViewModel
    {
        public RegistroViewModel()
        {
            ColorAcentuacionR = Color.FromHex("845EC2");
            Back_color = Color.FromHex("6551BD");
            Back_color2 = Color.FromHex("F7F4FB");
            Text_color = Color.White;
            Text_color2 = Color.FromHex("6551BD");
            Text_color3 = Color.Black;
            Text_color4 = Color.FromHex("845EC2");
            Placetxt = "Correo electrónico";
            Place_color = Color.Black;
            Border_color = Color.FromHex("6551BD");
            Etiq_texto = "Registro de Usuario";
            Etiq_texto2 = "Registrarse";
            Etiq_texto3 = "EasyShop";
            Etiq_texto4 = "Continuar como invitado";
            Etiq_texto5 = "Crear una cuenta";
            Etiq_texto6 = "Regresar";

        }

        public Color ColorAcentuacionR { get; private set; }

        public Color Back_color { get; private set; }
        public Color Back_color2 { get; private set; }
        public Color Text_color { get; private set; }
        public Color Text_color2 { get; private set; }
        public Color Text_color3 { get; private set; }
        public Color Text_color4 { get; private set; }
        public string Placetxt { get; private set; }
        public Color Place_color { get; private set; }
        public Color Border_color { get; private set; }
        public string Etiq_texto { get; private set; }
        public string Etiq_texto2 { get; private set; }
        public string Etiq_texto3 { get; private set; }
        public string Etiq_texto4 { get; private set; }

        public string Etiq_texto5 { get; private set; }
        public string Etiq_texto6 { get; private set; }
    }
}
