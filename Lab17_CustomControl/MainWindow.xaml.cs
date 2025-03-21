﻿using System;
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

namespace Lab17_CustomControl
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

        private void ColorChoise_ColorChanged(object sender, RoutedPropertyChangedEventArgs<Color> e)
        {
            txb.Text = "Полученный цвет: " + e.NewValue.ToString();
            txb.Foreground = new SolidColorBrush(e.NewValue);
        }
    }
}
