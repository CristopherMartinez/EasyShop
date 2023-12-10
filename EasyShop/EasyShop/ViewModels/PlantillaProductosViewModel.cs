using EasyShop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace EasyShop.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class PlantillaProductosViewModel : BaseViewModel
    {
        private string itemId;
        public string Id { get; set; }
        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        //public string Categoria {  get; set; }
        //public string DataTemplate { get; set; }

        //Categoria de Herramientas
        //public ObservableCollection<Herramienta> Herramientas { get; set; }

        //public PlantillaProductosViewModel()
        //{
        //    //if(ItemId == "catHerramientas")
        //    //{
        //    //    Categoria = "Herramientas";
        //    //    DataTemplate = "Models:Herramienta";


        //    //}

           

        //}


        public async void LoadItemId(string itemId)
        {
            try
            {
                //var item = await DataStore.GetItemAsync(itemId);
                Id = itemId;
                
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }


    }
}