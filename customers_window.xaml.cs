using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MessageBox = System.Windows.Forms.MessageBox;

namespace LogicielGestionCommandes
{
    /// <summary>
    /// Logique d'interaction pour customers_window.xaml
    /// </summary>
    public partial class customers_window : Window
    {

        public BindingSource customerList = new BindingSource();
        
        public customers_window()
        {
            InitializeComponent();
        }

        private void customer_window_load(object sender, RoutedEventArgs e)
        {
            using (var context = new NorthwindEntities())
            {
                customerList.DataSource = context.Customers.ToList();
            }

            this.dgCustomer.ItemsSource = customerList;
        }

        private void allProucts_click(object sender, RoutedEventArgs e)
        {

        }

        private void allOrders_click(object sender, RoutedEventArgs e)
        {

        }

        private void dgClient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Customer customer = (Customer)dgCustomer.SelectedItem;
            //System.Windows.Forms.MessageBox.Show("l'id du client "+customer.CustomerID);
            /*customerID.Text = customer.CustomerID;
            enterprisename.Text = customer.CompanyName;
            contactname.Text = customer.ContactName;
            contacttitle.Text = customer.ContactTitle;
            adress.Text = customer.Address;
            city.Text = customer.City;
            region.Text = customer.Region;
            postalcode.Text = customer.PostalCode;
            country.Text = customer.Country;
            phone.Text = customer.Phone;
            faxdeFax.Text = customer.Fax;*/
            // CustomerOrders co = new CustomerOrders();
            //co.ShowDialog();

            /*MessageBoxResult result = (MessageBoxResult)MessageBox.Show("Choisissez une option", "Action sur le client", MessageBoxButtons.YesNoCancel);
            if (result == MessageBoxResult.Yes)
            {
                customerID.Text = customer.CustomerID;
                enterprisename.Text = customer.CompanyName;
                contactname.Text = customer.ContactName;
                contacttitle.Text = customer.ContactTitle;
                adress.Text = customer.Address;
                city.Text = customer.City;
                region.Text = customer.Region;
                postalcode.Text = customer.PostalCode;
                country.Text = customer.Country;
                phone.Text = customer.Phone;
                faxdeFax.Text = customer.Fax;
            }*/

            var dialog = new BoiteDialog();
            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                CustomerOrders co = new CustomerOrders();
                co.ShowDialog();
            }
            else if(result == false)
            {
                customerID.Text = customer.CustomerID;
                enterprisename.Text = customer.CompanyName;
                contactname.Text = customer.ContactName;
                contacttitle.Text = customer.ContactTitle;
                adress.Text = customer.Address;
                city.Text = customer.City;
                region.Text = customer.Region;
                postalcode.Text = customer.PostalCode;
                country.Text = customer.Country;
                phone.Text = customer.Phone;
                faxdeFax.Text = customer.Fax;
            }else
            {
                dialog.Close();
            }
        }
        private void close_click(object sender, RoutedEventArgs e)
        {

        }
    }
}
