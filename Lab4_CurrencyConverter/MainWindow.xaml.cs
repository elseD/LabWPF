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

namespace Lab4_CurrencyConverter
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

        private void Button_Dollar_Click(object sender, RoutedEventArgs e)
        {
            if (dollarRate != null && dollarSum != null)
            {
                double rate = Convert.ToDouble(dollarRate.Text);
                double sum = Convert.ToDouble(dollarSum.Text);
                double result =  rate * sum;
                dollarResult.Text = result.ToString();
            }
        }

        private void Button_Euro_Click(object sender, RoutedEventArgs e)
        {
            if (euroRate != null && euroSum != null)
            {
                double result = Convert.ToDouble(euroRate.Text) * Convert.ToDouble(euroSum.Text);
                euroResult.Text = result.ToString();
            }
        }

        private void Button_Hryvnia_Click(object sender, RoutedEventArgs e)
        {
            if (hryvniaRate != null && hryvniaSum != null)
            {
                double result = Convert.ToDouble(hryvniaRate.Text) * Convert.ToDouble(hryvniaSum.Text);
                hryvniaResult.Text = result.ToString();
            }
        }

        private void Button_Drams_Click(object sender, RoutedEventArgs e)
        {
            if (dramsRate != null && dramsSum != null)
            {
                double result = Convert.ToDouble(dramsRate.Text) * Convert.ToDouble(dramsSum.Text);
                dramsResult.Text = result.ToString();
            }
        }

        private void Button_Inch_Click(object sender, RoutedEventArgs e)
        {
            if (inchInput != null)
            {
                double input = Convert.ToDouble(inchInput.Text);
                double result = input * 0.0254;
                inchToMetersResult.Text = result.ToString();
            }
        }

        private void Button_Foot_Click(object sender, RoutedEventArgs e)
        {
            if (ftInput != null)
            {
                double input = Convert.ToDouble(ftInput.Text);
                double result = input * 0.3048;
                ftToMetersResult.Text = result.ToString();
            }
        }

        private void Button_Mile_Click(object sender, RoutedEventArgs e)
        {
            if (mileInput != null)
            {
                double input = Convert.ToDouble(mileInput.Text);
                double result = input * 1609.344;
                mileToMetersResult.Text = result.ToString();
            }
        }
        private void Button_Verst_Click(object sender, RoutedEventArgs e)
        {
            if (verstInput != null)
            {
                double input = Convert.ToDouble(verstInput.Text);
                double result = input * 1066.8;
                verstToMetersResult.Text = result.ToString();
            }
        }
    }
}
