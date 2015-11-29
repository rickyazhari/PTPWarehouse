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
            Content.Children.Add(new areal_produksi());
        }

        private void exitbtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void laporan_menu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.MenuViewModel.SetOlap();
            App.MenuViewModel.SelectedItem = "olap";
        }

        private void fakta_menu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.MenuViewModel.SetFactMenu();
            App.MenuViewModel.SelectedItem = "fakta";
        }

        private void dimensi_menu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.MenuViewModel.SetDimensiMenu();
            App.MenuViewModel.SelectedItem = "dimensi";
        }


    }
}
