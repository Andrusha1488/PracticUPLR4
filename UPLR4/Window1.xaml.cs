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

namespace UPLR4
{
    
    public partial class Window1 : Window
    {
        private BurgerPlaceEntities context = new BurgerPlaceEntities();
        public Window1()
        {
            InitializeComponent();
            OrdersDataGrid.ItemsSource = context.Orders.ToList();
            CustomerDataGrid.ItemsSource = context.Customer.ToList();
        }

        private void PreviousTable_Click(object sender, RoutedEventArgs e)
        {
            CustomerDataGrid.Visibility = Visibility.Visible;
            OrdersDataGrid.Visibility = Visibility.Collapsed;
            NameTbxS.Visibility = Visibility.Collapsed;
            NameTbxS2.Visibility = Visibility.Visible;
        }

        private void NextTable_Click(object sender, RoutedEventArgs e)
        {
            CustomerDataGrid.Visibility = Visibility.Collapsed;
            OrdersDataGrid.Visibility = Visibility.Visible;
            NameTbxS.Visibility = Visibility.Visible;
            NameTbxS2.Visibility = Visibility.Collapsed;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            OrdersDataGrid.ItemsSource = context.Orders.ToList().Where(item => item.Orders_Food.Contains(NameTbxS.Text));
            CustomerDataGrid.ItemsSource = context.Customer.ToList().Where(item => item.CustomerName.Contains(NameTbxS2.Text));
        }
    }
}
