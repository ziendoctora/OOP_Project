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
using static Blah.MainWindow;

namespace Blah
{
    /// <summary>
    /// Interaction logic for AddTransaction.xaml
    /// </summary>
    public partial class AddTransaction : Window
    {
        public DataStorage data;
        public int counter;
        public AddTransaction()
        {
            Background = Brushes.DarkGray;
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.data = data;
            addCustomer.Show();
            counter = 1;
           
        }

        private void cmbProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            
            foreach (Person customer in data.customers)
                cmbCustomer.Items.Add(customer.GetFullName());
            if (counter == 1)
            {
                btnAddCustomer.IsEnabled = false;
            }
        }
    }
}
