using System.Collections.Generic;
using System.Windows;
using DevExpress.Wpf.NavBar;

namespace MVVM_SelectedItem {

    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();

            ViewModel viewModel = new ViewModel();
            DataBindingHelper.BuildContent(navBar, viewModel.Products,
                "Category", null, null);

            DataContext = viewModel;
        }
    }

    public class ViewModel : DependencyObject {
        public static readonly DependencyProperty SelectedItemProperty =
            DependencyProperty.Register("SelectedItem", typeof(object),
            typeof(ViewModel), new PropertyMetadata(null));

        List<Product> products;

        public List<Product> Products { get { return products; } }

        public ViewModel() {
            products = new List<Product>();
            for (int i = 0; i < 9; i++) {
                products.Add(new Product() {
                    Category = "Category" + i % 3,
                    Name = "Item" + i
                });
            }
        }
    }

    public class Product {
        public string Category { get; set; }
        public string Name { get; set; }
        public override string ToString() {
            return Name;
        }
    }
}
