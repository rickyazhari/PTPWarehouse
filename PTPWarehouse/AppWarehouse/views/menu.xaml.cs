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
    /// Interaction logic for menu.xaml
    /// </summary>
    public partial class menu : UserControl
    {
        public main Parent;
        public menu(main x)
        {
            InitializeComponent();
            DataContext = App.MenuViewModel;
            Parent = x;
        }

        private void ListMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (App.MenuViewModel.SelectedItem == Constant.DIMENSI_SELECTED)
            {
                switch (ListMenu.SelectedIndex)
                {
                    case 1 :
                        App.DimfactViewModel.HeadTabel = "Dimensi Barang Bahan";
                        App.DimfactViewModel.GenerateTabel(Constant.TABEL_BARANG_BAHAN);
                        break;

                    case 2 :
                        App.DimfactViewModel.HeadTabel = "Dimensi Hama";
                        App.DimfactViewModel.GenerateTabel(Constant.TABEL_HAMA);
                        break;

                    case 3 :
                        App.DimfactViewModel.HeadTabel = "Dimensi Lahan";
                        App.DimfactViewModel.GenerateTabel(Constant.TABEL_LAHAN);
                        break;

                    case 4 :
                        App.DimfactViewModel.HeadTabel = "Dimensi Nyiang";
                        App.DimfactViewModel.GenerateTabel(Constant.TABEL_NYIANG);
                        break;

                    case 5 :
                        App.DimfactViewModel.HeadTabel = "Dimensi Pangkas";
                        App.DimfactViewModel.GenerateTabel(Constant.TABEL_PANGKAS);
                        break;

                    case 6 :
                        App.DimfactViewModel.HeadTabel = "Dimensi Pemetikan";
                        App.DimfactViewModel.GenerateTabel(Constant.TABEL_PEMETIKAN);
                        break;

                    case 7 :
                        App.DimfactViewModel.HeadTabel = "Dimensi Pupuk";
                        App.DimfactViewModel.GenerateTabel(Constant.TABEL_PUPUK);
                        break;

                    case 8 :
                        App.DimfactViewModel.HeadTabel = "Dimensi Tanah";
                        App.DimfactViewModel.GenerateTabel(Constant.TABEL_TANAH);
                        break;

                    case 9 :
                        App.DimfactViewModel.HeadTabel = "Dimensi Waktu";
                        App.DimfactViewModel.GenerateTabel(Constant.TABEL_WAKTU);
                        break;

                    default:
                        App.DimfactViewModel.HeadTabel = "Dimensi Area";
                        App.DimfactViewModel.GenerateTabel(Constant.TABEL_AREA);
                        break;
                }
            }

            if (App.MenuViewModel.SelectedItem == Constant.FAKTA_SELECTED)
            {
                switch (ListMenu.SelectedIndex)
                {
                    case 1:
                        App.DimfactViewModel.HeadTabel = "Fakta Barang Bahan";
                        App.DimfactViewModel.GenerateTabel(Constant.TABEL_FACT_BARANG_BAHAN);
                        break;

                    case 2:
                        App.DimfactViewModel.HeadTabel = "Fakta Curah Hujan";
                        App.DimfactViewModel.GenerateTabel(Constant.TABEL_FACT_CURAH_HUJAN);
                        break;

                    case 3:
                        App.DimfactViewModel.HeadTabel = "Fakta Dawungan";
                        App.DimfactViewModel.GenerateTabel(Constant.TABEL_FACT_DAWUNGAN);
                        break;

                    case 4:
                        App.DimfactViewModel.HeadTabel = "Fakta Fungsida Penyakit";
                        App.DimfactViewModel.GenerateTabel(Constant.TABEL_FACT_FUNGISIDA_PENYAKIT);
                        break;

                    case 5:
                        App.DimfactViewModel.HeadTabel = "Fakta Inteksida Hama";
                        App.DimfactViewModel.GenerateTabel(Constant.TABEL_FACT_INTEKSIDA_HAMA);
                        break;

                    case 6:
                        App.DimfactViewModel.HeadTabel = "Fakta Konsensi";
                        App.DimfactViewModel.GenerateTabel(Constant.TABEL_FACT_KONSENSI);
                        break;

                    case 7:
                        App.DimfactViewModel.HeadTabel = "Fakta Pemangkasan";
                        App.DimfactViewModel.GenerateTabel(Constant.TABEL_FACT_PEMANGKASAN);
                        break;

                    case 8:
                        App.DimfactViewModel.HeadTabel = "Fakta Pemupukan";
                        App.DimfactViewModel.GenerateTabel(Constant.TABEL_FACT_PEMUPUKAN);
                        break;

                    case 9:
                        App.DimfactViewModel.HeadTabel = "Fakta Pengendalian Hama";
                        App.DimfactViewModel.GenerateTabel(Constant.TABEL_FACT_PENGENDALIAN_HAMA);
                        break;

                    case 10:
                        App.DimfactViewModel.HeadTabel = "Fakta Pengendalian Penyakit";
                        App.DimfactViewModel.GenerateTabel(Constant.TABEL_FACT_PENGENDALIAN_PENYAKIT);
                        break;

                    case 11:
                        App.DimfactViewModel.HeadTabel = "Fakta Penyiangan";
                        App.DimfactViewModel.GenerateTabel(Constant.TABEL_FACT_PENYIANGAN);
                        break;

                    case 12:
                        App.DimfactViewModel.HeadTabel = "Fakta Produksi";
                        App.DimfactViewModel.GenerateTabel(Constant.TABEL_FACT_PRODUKSI);
                        break;

                    case 13:
                        App.DimfactViewModel.HeadTabel = "Fakta Semprot Hama";
                        App.DimfactViewModel.GenerateTabel(Constant.TABEL_FACT_SEMPROT_HAMA);
                        break;

                    case 14:
                        App.DimfactViewModel.HeadTabel = "Fakta Semprot Penyakit";
                        App.DimfactViewModel.GenerateTabel(Constant.TABEL_FACT_SEMPROT_PENYAKIT);
                        break;

                    case 15:
                        App.DimfactViewModel.HeadTabel = "Fakta Serangan Hama";
                        App.DimfactViewModel.GenerateTabel(Constant.TABEL_FACT_SERANGAN_HAMA);
                        break;

                    case 16:
                        App.DimfactViewModel.HeadTabel = "Fakta Serangan Penyakit";
                        App.DimfactViewModel.GenerateTabel(Constant.TABEL_FACT_SERANGAN_PENYAKIT);
                        break;

                    case 17:
                        App.DimfactViewModel.HeadTabel = "Fakta Target Produksi";
                        App.DimfactViewModel.GenerateTabel(Constant.TABEL_FACT_TARGET_PRODUKSI);
                        break;

                    default:
                        App.DimfactViewModel.HeadTabel = "Fakta Area Produksi";
                        App.DimfactViewModel.GenerateTabel(Constant.TABEL_FACT_AREA_PRODUKSI);
                        break;
                }
            }

            if (App.MenuViewModel.SelectedItem == Constant.OLAP_SELECTED)
            {
                Parent.Con.Children.Clear();
                switch (ListMenu.SelectedIndex)
                {
                    case 1 :
                        Parent.Con.Children.Add(new OLAP.BarangBahan());
                        break;

                    case 2 :
                        Parent.Con.Children.Add(new OLAP.CurahHujan());
                            break;
                    
                    case 3 :
                            Parent.Con.Children.Add(new OLAP.Dawungan());
                            break;

                    case 4 :
                        Parent.Con.Children.Add(new OLAP.FungisidaPenyakit());
                        break;

                    case 5 :
                        Parent.Con.Children.Add(new OLAP.InteksidaHama());
                        break;

                    case 6 :
                        Parent.Con.Children.Add(new OLAP.Konsensi());
                        break;

                    case 7 :
                        Parent.Con.Children.Add(new OLAP.Pemangkasan());
                        break;
                    
                    case 8:
                        Parent.Con.Children.Add(new OLAP.Pemupukan());
                        break;

                    case 9:
                        Parent.Con.Children.Add(new OLAP.PengendalianHama());
                        break;

                    case 10:
                        Parent.Con.Children.Add(new OLAP.PengendalianPenyakit());
                        break;

                    case 11:
                        Parent.Con.Children.Add(new OLAP.Penyiangan());
                        break;

                    case 12:
                        Parent.Con.Children.Add(new OLAP.Produksi());
                        break;

                    case 13:
                        Parent.Con.Children.Add(new OLAP.SemprotHama());
                        break;
                    case 14:
                        Parent.Con.Children.Add(new OLAP.SemprotPenyakit());
                        break;

                    case 15:
                        Parent.Con.Children.Add(new OLAP.SeranganHama());
                        break;

                    case 16:
                        Parent.Con.Children.Add(new OLAP.SeranganPenyakit());
                        break;

                    case 17:
                        Parent.Con.Children.Add(new OLAP.TargetProduksi());
                        break;

                    default :
                        Parent.Con.Children.Add(new OLAP.LuasArealProduksi());
                        break;
                }
            }
        }
    }
}
