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

namespace AppWarehouse.views
{
    /// <summary>
    /// Interaction logic for DimFact.xaml
    /// </summary>
    public partial class DimFact : UserControl
    {
        public DimFact()
        {
            InitializeComponent();
            DataContext = App.DimfactViewModel;
            if (App.MenuViewModel.SelectedItem == Constant.DIMENSI_SELECTED)
            {
                App.DimfactViewModel.HeadTabel = "Dimensi Area";
                App.DimfactViewModel.GenerateTabel(Constant.TABEL_AREA);
            }

            if (App.MenuViewModel.SelectedItem == Constant.FAKTA_SELECTED)
            {
                App.DimfactViewModel.HeadTabel = "Fakta Area Produksi";
                App.DimfactViewModel.GenerateTabel(Constant.TABEL_FACT_AREA_PRODUKSI);
            }
        }
    }
}
