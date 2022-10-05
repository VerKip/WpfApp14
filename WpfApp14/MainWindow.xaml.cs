using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProdName = "Манго",
                ProdPrice = 300,
                ProdImage = "Data/Mango.jpg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                ProdName = "Авокадо",
                ProdPrice = 200,
                ProdImage = "Data/Avocado.jpg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                ProdName = "Смартфон iphone 14",
                ProdPrice = 100000,
                ProdImage = "Data/Iphone.jpg",
                ProductCategory = ProductCategories.Appliances
            });
            products.Add(new Product()
            {
                ProdName = "Стиральная машина",
                ProdPrice = 40000,
                ProdImage = "Data/WM.jpg",
                ProductCategory = ProductCategories.Appliances
            });
            products.Add(new Product()
            {
                ProdName = "Сушильная машина",
                ProdPrice = 45000,
                ProdImage = "Data/DM.jpeg",
                ProductCategory = ProductCategories.Appliances
            });
            listBox.ItemsSource = products;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            products.Add(new Product()
            {
                ProdName = "Гранат",
                ProdPrice = 130,
                ProdImage = "Data/Granat.jpg",
                ProductCategory = ProductCategories.Food
            });
        }
    }
}
