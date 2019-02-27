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

namespace Blah
{
    /// <summary>
    /// Interaction logic for AddJewelry.xaml
    /// </summary>
    public partial class AddJewelry : Window
    {
        AddTransaction addTransA = new AddTransaction();
        Product jewelry = new Product();

        public AddJewelry()
        {
            Background = Brushes.DarkGray;
            InitializeComponent();
        }


        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
