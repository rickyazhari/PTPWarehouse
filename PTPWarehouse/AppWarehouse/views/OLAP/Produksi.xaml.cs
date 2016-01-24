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

namespace AppWarehouse.views.OLAP
{
    /// <summary>
    /// Interaction logic for LuasArealProduksi.xaml
    /// </summary>
    public partial class Produksi : UserControl
    {
        private string vis = "pivot";
        public Produksi()
        {
                InitializeComponent();
        }

        private void kloonal_Checked(object sender, RoutedEventArgs e)
        {
            dataArea.Caption = "Realisasi";
            dataArea.FieldName = "[Measures].[Realisasi]";
        }

        private void Seeding_Checked(object sender, RoutedEventArgs e)
        {
            dataArea.Caption = "Kapasitas";
            dataArea.FieldName = "[Measures].[KapasitasAvg]";
        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
           
            if(vis =="chart")
            {
                chartControl.Visibility = System.Windows.Visibility.Collapsed;
                pivotGridControl.Visibility = System.Windows.Visibility.Visible;
                vis = "pivot";
            }
        }

        private void Chart_Click(object sender, RoutedEventArgs e)
        {
            if (vis=="pivot")
            {
                pivotGridControl.Visibility = System.Windows.Visibility.Collapsed;
                chartControl.Visibility = System.Windows.Visibility.Visible;
                vis = "chart";
            }
        }

        private void Pivot_Click(object sender, RoutedEventArgs e)
        {
            var parent = Window.GetWindow(this);
            pivotGridControl.ShowPrintPreviewDialog(parent, "Areal Produksi", "Areal Produksi");
        }

    }
}
