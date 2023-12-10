using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Text;

namespace EasyShop.ViewModels
{
    public class CierreSesionViewModel
    {
        public CierreSesionViewModel()
        {
            ColorAcentuacionC = Color.FromHex("845EC2");
            EtiqBienvenidoC = Color.FromHex("845EC2");
            TextoCierreC = "     Cerrar Sesión     ";
            TextoCancelar = "Cancelar";
            Back_colorC = Color.FromHex("6551BD");

            Text_colorC = Color.White;
            Text_color2 = Color.FromHex("6551BD");
            Text_color3 = Color.FromHex("845EC2");
            Etiq_texto1 = "Regresar";
            EtiqInvitadoC = "Solo puedes cerrar sesión cuando tengas una cuenta registrada diferente a invitado.";
        }

        public Color ColorAcentuacionC { get; private set; }
        public Color EtiqBienvenidoC { get; private set; }
        public string TextoCierreC { get; private set; }
        public string TextoCancelar { get; private set; }
        public Color Back_colorC { get; private set; }
        public Color Text_colorC { get; private set; }
        public Color Text_color2 { get; private set; }
        public Color Text_color3 { get; private set; }
        public string Etiq_texto1 { get; private set; }
        public string EtiqInvitadoC { get; private set; }
    }
}
