using System;
using System.Collections.Generic;
using System.Data;
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
using UPLR4.BurgerPlaceDataSetTableAdapters;

namespace UPLR4
{

    public partial class MainWindow : Window
    {
        OrdersTableAdapter orders = new OrdersTableAdapter();
        CustomerTableAdapter customers = new CustomerTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            OrdersDataGrid.ItemsSource = orders.GetData();
            CustomerDataGrid.ItemsSource = customers.GetData();

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

            OrdersDataGrid.ItemsSource = orders.SearchByFood(NameTbxS.Text);
            CustomerDataGrid.ItemsSource = customers.SearchByName(NameTbxS2.Text);
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
        }
    }
}
