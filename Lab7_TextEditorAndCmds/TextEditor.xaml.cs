using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Lab7_TextEditorAndCmds
{
    /// <summary>
    /// Interaction logic for TextEditor.xaml
    /// </summary>
    public partial class TextEditor : Window
    {
        public TextEditor()
        {
            InitializeComponent();
        }

        private void Button_Bold_Click(object sender, RoutedEventArgs e)
        {
            if (textBox != null && textBox.FontWeight == FontWeights.Normal)
            {
                textBox.FontWeight = FontWeights.Bold;
                (sender as Button).BorderBrush = Brushes.DarkViolet;
            }
            else if(textBox != null)
            {
                textBox.FontWeight = FontWeights.Normal;
                (sender as Button).BorderBrush = Brushes.Gray;
            }
        }

        private void Button_Italic_Click(object sender, RoutedEventArgs e)
        {
            if (textBox != null && textBox.FontStyle == FontStyles.Normal)
            {
                textBox.FontStyle = FontStyles.Italic;
                (sender as Button).BorderBrush = Brushes.DarkViolet;
            }
            else if (textBox != null)
            {
                textBox.FontStyle = FontStyles.Normal;
                (sender as Button).BorderBrush = Brushes.Gray;
            }
        }

        private void Button_Underline_Click(object sender, RoutedEventArgs e)
        {
            if (textBox != null && textBox.TextDecorations == null)
            {
                textBox.TextDecorations = TextDecorations.Underline;
                (sender as Button).BorderBrush = Brushes.DarkViolet;
            }
            else if(textBox != null)
            {
                textBox.TextDecorations = null;
                (sender as Button).BorderBrush = Brushes.Gray;
            }
        }

        private void RadioButtonBlack_Checked(object sender, RoutedEventArgs e)
        {
            if(textBox != null && (sender as RadioButton).IsChecked == true)
            {
                textBox.Foreground = Brushes.Black;
            }
        }

        private void RadioButtonRed_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null && (sender as RadioButton).IsChecked == true)
            {
                textBox.Foreground = Brushes.Red;
            }
        }

        private void ComboBox_FontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (textBox != null)
            {
                double size = Convert.ToDouble(((sender as ComboBox).SelectedItem as TextBlock).Text);
                textBox.FontSize = size;
            }
        }

        private void ComboBox_FontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (textBox != null)
            {
                string family = ((sender as ComboBox).SelectedItem as TextBlock).Text;
                textBox.FontFamily = new FontFamily(family);
            }
        }

        private void ExitExecuted(object sender, ExecutedRoutedEventArgs e)
        {

            MessageBoxResult result = MessageBox.Show("Do you want exit?", "Exit", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void OpenExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (.txt, .doc, .docx)|*.txt;*.doc;*.docx|Все файлы(*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                textBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (.txt)|*.txt|Все файлы(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, textBox.Text);
            }
        }

        private void IsExitExecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            if (textBox.Text != null)
            {
                if(textBox.Text.Length > 10)
                {
                    e.CanExecute = true;
                }
                else
                {
                    e.CanExecute = false;
                }
            }
        }
    }
}
