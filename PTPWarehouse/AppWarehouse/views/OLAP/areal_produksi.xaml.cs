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
    /// Interaction logic for areal_produksi.xaml
    /// </summary>
    public partial class areal_produksi : UserControl
    {
        public areal_produksi()
        {
            InitializeComponent();
        }

        private void kloonal_Checked(object sender, RoutedEventArgs e)
        {
            DataArea.Caption = "Kloonal";
            DataArea.FieldName = "[Measures].[Cloonal]";
        }
    }
}
