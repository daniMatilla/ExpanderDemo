using System;
using System.Collections.Generic;
using System.Linq;
using ShoppingList.ViewModels;
using Xamarin.Forms;

namespace ShoppingList.Views
{
    public partial class ShoppingListView : ContentPage
    {
        public ShoppingListView()
        {
            InitializeComponent();
            BindingContext = new ShoppingListViewModel();
        }
    }
}