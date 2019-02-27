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

namespace Blah
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataStorage data = new DataStorage();
        AddJewelry addJewel = new AddJewelry();

        public MainWindow()
        {
            Background = Brushes.DarkGray;
            InitializeComponent();

        }
        private void btnInventory_Click(object sender, RoutedEventArgs e)
        {
            addJewel.Show();
            //this.Hide();
        }

        private void btnAddTransaction_Click(object sender, RoutedEventArgs e)
        {
            AddTransaction addTransaction = new AddTransaction();
            addTransaction.data = data;
            addTransaction.Show();
            //this.Hide();
        }

        public class DataStorage
        {
            public List<Person> customers = new List<Person>();
            public List<Product> jewelries = new List<Product>();
        }
    }

       
}
