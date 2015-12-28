using System;
using AppWarehouse.views.OLAP;
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

namespace AppWarehouse.views
{
    /// <summary>
    /// Interaction logic for main.xaml
    /// </summary>
    public partial class main : Window
    {
        public main()
        {
            InitializeComponent();
            submenu.Children.Add(new menu());
            Con.Children.Clear();
            Con.Children.Add(new LuasArealProduksi());
        }

        private void exitbtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void laporan_menu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Con.Children.Clear();
            App.MenuViewModel.SetOlap();
            App.MenuViewModel.SelectedItem = Constant.OLAP_SELECTED;
            Con.Children.Add(new LuasArealProduksi());
        }

        private void fakta_menu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Con.Children.Clear();
            App.MenuViewModel.SetFactMenu();
            App.MenuViewModel.SelectedItem = Constant.FAKTA_SELECTED;
            Con.Children.Add(new DimFact());
        }

        private void dimensi_menu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Con.Children.Clear();
            App.MenuViewModel.SetDimensiMenu();
            App.MenuViewModel.SelectedItem = Constant.DIMENSI_SELECTED;
            Con.Children.Add(new DimFact());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            
        }


    }
}
