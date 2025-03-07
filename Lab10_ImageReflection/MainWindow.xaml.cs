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

namespace Lab10_ImageReflection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if((sender as Button).Tag.ToString() == "fishes")
            {
                fishesPanel.Visibility = Visibility.Visible;
                starsPanel.Visibility = Visibility.Collapsed;
            }
            else if((sender as Button).Tag.ToString() == "stars")
            {
                fishesPanel.Visibility = Visibility.Collapsed;
                starsPanel.Visibility = Visibility.Visible;
            }
        }
    }
}
