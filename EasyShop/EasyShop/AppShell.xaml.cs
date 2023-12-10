using EasyShop.ViewModels;
using EasyShop.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace EasyShop
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(Herramientas), typeof(Herramientas));
            Routing.RegisterRoute(nameof(Verduras), typeof(Verduras));
            Routing.RegisterRoute(nameof(Juguetes), typeof(Juguetes));
            Routing.RegisterRoute(nameof(Hogar), typeof(Hogar));
            Routing.RegisterRoute(nameof(Personal), typeof(Personal));
            Routing.RegisterRoute(nameof(CarritoCompras), typeof(CarritoCompras));
            Routing.RegisterRoute(nameof(Ticket), typeof(Ticket));
            Routing.RegisterRoute(nameof(TempPage), typeof(TempPage));

            if (Application.Current.Properties.ContainsKey("Usuario"))
            {
                Application.Current.Properties.Remove("Usuario");
                Application.Current.Properties["Usuario"] = "Invitado";
            }
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
