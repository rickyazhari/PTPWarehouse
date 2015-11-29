using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;

namespace AppWarehouse.views
{
    /// <summary>
    /// Interaction logic for etl.xaml
    /// </summary>
    public partial class etl : Window
    {
        public etl()
        {
            InitializeComponent();
            DataContext = App.ETLViewModel;
        }

        private void exitbtn_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Etlbtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Dispatcher.BeginInvoke(new Action(() => Etlbtn.Visibility = System.Windows.Visibility.Hidden));
            Application.Current.Dispatcher.BeginInvoke(new Action(() => proseslbl.Visibility = System.Windows.Visibility.Visible));
            Application.Current.Dispatcher.BeginInvoke(new Action(() => pbLoading.Visibility = System.Windows.Visibility.Visible));
            string x = App.ETLViewModel.load_etl();
            if (App.ETLViewModel.Etl.Pack.ExecutionResult.ToString().ToLower() == Constant.ETL_FAILURE)
            {
                MessageBox.Show("Terjadi kesalahan pada sistem. proses ekseskusi data dibatalkan. silahkan di coba lagi", "General Error", MessageBoxButton.OK);
            }
            else
            {
                var cont = new main();
                cont.Show();
                this.Close();
            }
            Etlbtn.Visibility = System.Windows.Visibility.Visible;
            proseslbl.Visibility = System.Windows.Visibility.Hidden;
            pbLoading.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
