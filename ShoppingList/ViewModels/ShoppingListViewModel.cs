using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using ShoppingList.Models;
using ShoppingList.Services;
using Xamarin.Forms;

namespace ShoppingList.ViewModels
{
    public class ShoppingListViewModel : BindableObject
    {
        ShoppingItem _lastExpander;
        ObservableCollection<ShoppingItem> _categories;

        public ObservableCollection<ShoppingItem> Categories
        {
            get { return _categories; }
            set
            {
                _categories = value;
                OnPropertyChanged();
            }
        }

        string _find;

        public string Find
        {
            get { return _find; }
            set
            {
                _find = value;
                OnPropertyChanged();
            }
        }

        public ICommand GoToCommand { get; set; }
        public ICommand ExpandCommand { get; set; }

        public ShoppingListViewModel()
        {
            GoToCommand = new Command(GoToCommandHandler);
            ExpandCommand = new Command<ShoppingItem>(ExpandCommandHandler);
            LoadShoppingList();
        }

        void LoadShoppingList()
        {
            var items = ShoppingService.Instance.GetShoppingList();
            Categories = new ObservableCollection<ShoppingItem>(items);
        }

        private void GoToCommandHandler()
        {
            foreach (var it in Categories)
            {
                it.IsDetailVisible = it.Items.Exists(i => i.Name == Find);
                SetLastExpander(it);
            }
        }

        private void ExpandCommandHandler(object item)
        {
            if (!(item is ShoppingItem sh)) return;
            if (_lastExpander == sh) return;
            
            foreach (var ca in Categories)
            {
                ca.IsDetailVisible = ca.Name == sh.Name;
                SetLastExpander(ca);
            }
        }

        private void SetLastExpander(ShoppingItem item)
        {
            if (item.IsDetailVisible)
                _lastExpander = item;
        }
    }
}