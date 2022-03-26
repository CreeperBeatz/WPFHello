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

namespace WPFhello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ListBoxItem james = new ListBoxItem();
            james.Content = "Willy Fisterbutt";
            peopleListBox.Items.Add(james);
            peopleListBox.SelectedItem = james;
        }

        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            /*
            if (textName.Text.Length > 2)
            {
                MessageBox.Show($"Hello {textName.Text}, this is my first WPF app in VS20**");
            }
            else
            {
                MessageBox.Show($"Hello, it seems like you don't have a name!");
            }
            */

            //MessageBox.Show($"Hello {(peopleListBox.SelectedItem as ListBoxItem).Content.ToString()}, to my first WPF app");

            MyMessage myMessage = new MyMessage();
            myMessage.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int factoriel = int.Parse(factoriel_box.Text);
                double num = double.Parse(num_box.Text);
                double pow = double.Parse(pow_box.Text);

                // Calc factorial and display it
                int factoriel_result = 1;
                while (factoriel > 0)
                {
                    factoriel_result *= factoriel;
                    factoriel--;
                }
                factoriel_block.Text = factoriel_result.ToString();

                // Calc pow and display it
                pow_block.Text = Math.Pow(num, pow).ToString();

            } catch(FormatException) {
                MessageBox.Show("Invalid format! Please enter numbers only!");
            }
        }

        private void MainWindowClosed(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you really want to do that?",
                "Warning", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
