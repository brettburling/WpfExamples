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

namespace WpfCustomComponents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //add some items to the combo
            var items = new List<string>();
            items.Add("Item01");
            items.Add("Item02");
            items.Add("Item03");
            items.Add("Item04");
            items.Add("Item04");


            combo.ItemsSource =items;
        }

        private void pbutton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Primary Button was clicked");
        }

        private void sbutton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Secondary Button was clicked");
        }
    }
}
