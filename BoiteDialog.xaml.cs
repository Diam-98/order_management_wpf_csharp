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
using System.Windows.Shapes;

namespace LogicielGestionCommandes
{
    /// <summary>
    /// Logique d'interaction pour BoiteDialog.xaml
    /// </summary>
    public partial class BoiteDialog : Window
    {
        public BoiteDialog()
        {
            InitializeComponent();
        }

        private void view_orders(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void action_on_customer(object sender, RoutedEventArgs e)
        {
            DialogResult=false;
        }

        private void cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
