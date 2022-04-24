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

namespace LogicielGestionCommandes
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void all_customers_click(object sender, RoutedEventArgs e)
        {
            customers_window cw = new customers_window();
            cw.ShowDialog();
        }

        private void all_orders_details_click(object sender, RoutedEventArgs e)
        {
            order_details_window odw = new order_details_window();
            odw.ShowDialog();
        }

        private void all_product_click(object sender, RoutedEventArgs e)
        {
            products_window pw = new products_window();
            pw.ShowDialog();
        }

        private void all_orders_click(object sender, RoutedEventArgs e)
        {
            orders_window ow = new orders_window();
            ow.ShowDialog();
        }

        private void soft_close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
