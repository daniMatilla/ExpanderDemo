using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ShoppingList.Models
{
    public class ShoppingItem : BindableObject
    {
        public string Name { get; set; }

        bool _isDetailVisible;

        public bool IsDetailVisible
        {
            get { return _isDetailVisible; }
            set
            {
                _isDetailVisible = value;
                OnPropertyChanged();
            }
        }

        public List<ShoppingDetailItem> Items { get; set; }
    }

    public class ShoppingDetailItem
    {
        public string Name { get; set; }
    }
}