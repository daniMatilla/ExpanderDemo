using System.Collections.Generic;
using ShoppingList.Models;
using Xamarin.Forms;

namespace ShoppingList.Services
{
    public class ShoppingService
    {
        static ShoppingService _instance;

        public static ShoppingService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ShoppingService();
                return _instance;
            }
        }

        public List<ShoppingItem> GetShoppingList()
        {
            return new List<ShoppingItem>
            {
                new ShoppingItem
                {
                    Name = "Breads and pastries",
                    Items = new List<ShoppingDetailItem>
                    {
                        new ShoppingDetailItem {Name = "Grain bread"},
                        new ShoppingDetailItem {Name = "Rolls"},
                        new ShoppingDetailItem {Name = "Cookies"},
                        new ShoppingDetailItem {Name = "Chocolate cake"},
                        new ShoppingDetailItem {Name = "Fruit cake"},
                        new ShoppingDetailItem {Name = "Baguette"},
                    }
                },
                new ShoppingItem
                {
                    Name = "Fish",
                    Items = new List<ShoppingDetailItem>
                    {
                        new ShoppingDetailItem {Name = "Swordfish"},
                        new ShoppingDetailItem {Name = "Tuna"},
                        new ShoppingDetailItem {Name = "Salmon"},
                    }
                },
                new ShoppingItem
                {
                    Name = "Meat",
                    Items = new List<ShoppingDetailItem>
                    {
                        new ShoppingDetailItem {Name = "Chicken wings"},
                        new ShoppingDetailItem {Name = "Pork"},
                        new ShoppingDetailItem {Name = "Chicken breast"},
                    }
                },
                new ShoppingItem
                {
                    Name = "Fruits",
                    Items = new List<ShoppingDetailItem>
                    {
                        new ShoppingDetailItem {Name = "Bananas"},
                        new ShoppingDetailItem {Name = "Apples"},
                        new ShoppingDetailItem {Name = "Strawberries"},
                    }
                },
                new ShoppingItem
                {
                    Name = "Vegetable",
                    Items = new List<ShoppingDetailItem>
                    {
                        new ShoppingDetailItem {Name = "Carrots"},
                        new ShoppingDetailItem {Name = "Salad"},
                        new ShoppingDetailItem {Name = "Pumpkin"},
                    }
                },
            };
        }
    }
}