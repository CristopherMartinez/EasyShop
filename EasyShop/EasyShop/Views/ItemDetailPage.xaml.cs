using EasyShop.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace EasyShop.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}