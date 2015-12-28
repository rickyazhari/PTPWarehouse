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
using Microsoft.SqlServer.Dts.Runtime;
using System.ComponentModel;
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
            System.Windows.Application.Current.Shutdown();
        }

        private void Etlbtn_Click(object sender, RoutedEventArgs e)
        {
            DTSExecResult x = new DTSExecResult();
            Etlbtn.Dispatcher.BeginInvoke(new Action(() => Etlbtn.Visibility = System.Windows.Visibility.Hidden));
            pbLoading.Dispatcher.BeginInvoke(new Action(() => pbLoading.Visibility = System.Windows.Visibility.Visible));
            proseslbl.Dispatcher.BeginInvoke(new Action(() => proseslbl.Visibility = System.Windows.Visibility.Visible));
            var bw = new BackgroundWorker();
            App.ETLViewModel.Loading = true;
            bw.DoWork += (Sender, args) =>
            {
                x = App.ETLViewModel.load_etl();
            };
            bw.RunWorkerCompleted += (Sender, args) =>
            {
                App.ETLViewModel.Loading = false;
                if (x == DTSExecResult.Success)
                {
                    main cont = new main();
                    cont.Show();
                    this.Close();
                }
                else
                {
                    string err = string.Empty;
                    foreach (var p in App.ETLViewModel.Etl.Pack.Errors)
                    {
                        err += p.Description.ToString();
                    }
                    MessageBox.Show(err);
                    MessageBox.Show("Terjadi kesalahan pada sistem. proses ekseskusi data dibatalkan. silahkan di coba lagi", "General Error", MessageBoxButton.OK);
                    Etlbtn.Dispatcher.BeginInvoke(new Action(() => Etlbtn.Visibility = System.Windows.Visibility.Visible));
                    pbLoading.Dispatcher.BeginInvoke(new Action(() => pbLoading.Visibility = System.Windows.Visibility.Hidden));
                    proseslbl.Dispatcher.BeginInvoke(new Action(() => proseslbl.Visibility = System.Windows.Visibility.Hidden));
                }
            };
            bw.RunWorkerAsync();
        }
    }
}
