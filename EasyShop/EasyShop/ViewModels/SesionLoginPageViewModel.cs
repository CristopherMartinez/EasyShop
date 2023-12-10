using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace EasyShop.ViewModels
{
    public class SesionLoginViewModel
    {
        public SesionLoginViewModel()
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
            Texto_W = Color.Black;

            Etiq_texto = "Inicio de Sesión";

            Etiq_texto2 = "Iniciar sesión";
            Etiq_texto3 = "EasyShop";
            Etiq_texto4 = "Cancelar";



        }

        public object ColorAcentuacionR { get; private set; }
        public Color Back_color { get; private set; }
        public Color Back_color2 { get; private set; }
        public Color Text_color { get; private set; }
        public Color Text_color2 { get; private set; }
        public Color Text_color3 { get; private set; }
        public Color Text_color4 { get; private set; }
        public string Placetxt { get; private set; }
        public Color Place_color { get; private set; }
        public Color Border_color { get; private set; }
        public Color Texto_W { get; private set; }
        public string Etiq_texto { get; private set; }
        public string Etiq_texto2 { get; private set; }
        public string Etiq_texto3 { get; private set; }
        public string Etiq_texto4 { get; private set; }


    }
}