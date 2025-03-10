using System;
using System.Collections.Generic;
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

namespace Lab14_DataTemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Разработать шаблон данных для отображения списка товаров в компоненте ListBox.
        // При помощи триггеров определите разный шаблон для товаров категории Еда и категории Бытовая техника.
        public List<Product> productList;

        public MainWindow()
        {
            InitializeComponent();
            productList = new List<Product>()
            {
                new Product()
                {
                    ProductName = "Ананас",
                    Price = 250,
                    ImgSource = "Img/pineapple.jpg",
                    ProductCategory = CategoryList.Food
                },
                new Product()
                {
                    ProductName = "Блендер",
                    Price = 2500,
                    ImgSource = "Img/blender.jpg",
                    ProductCategory = CategoryList.HouseholdAppliances
                },
                new Product()
                {
                    ProductName = "Варенье из клубники",
                    Price = 210,
                    ImgSource = "Img/jar.jpg",
                    ProductCategory = CategoryList.Food
                },
                new Product()
                {
                    ProductName = "Гладильная система",
                    Price = 1000,
                    ImgSource = "Img/steamSystem.jpg",
                    ProductCategory = CategoryList.HouseholdAppliances
                },
                new Product()
                {
                    ProductName = "Дубайский шоколад",
                    Price=1490,
                    ImgSource = "Img/choko.jpg",
                    ProductCategory = CategoryList.Food
                },
            };

            lstBox.ItemsSource = productList;
        }
    }
}
