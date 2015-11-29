using AppWarehouse.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace AppWarehouse.viewmodel
{
    public class MenuViewModel : BaseBindable
    {
        private string selectedItem = string.Empty;

        public string SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value; }
        }

        private ObservableCollection<MenuModel> menu;

        public ObservableCollection<MenuModel> Menu
        {
            get
            {
                if (menu == null)
                {
                    menu = new ObservableCollection<MenuModel>();
                } 
                return menu; }
            set { TryChangeProperty(ref menu, value, "Menu"); }
        }

        public MenuViewModel()
        {
                SetOlap();
        }

        public void SetDimensiMenu()
        {
            Menu.Clear();
            Menu.Add(new MenuModel() { NamaMenu = "Dimensi Area" });
            Menu.Add(new MenuModel() { NamaMenu = "Dimensi Barang Bahan" });
            Menu.Add(new MenuModel() { NamaMenu = "Dimensi Hama" });
            Menu.Add(new MenuModel() { NamaMenu = "Dimensi Lahan" });
            Menu.Add(new MenuModel() { NamaMenu = "Dimensi Nyiang" });
            Menu.Add(new MenuModel(){NamaMenu = "Dimensi Pangkas"});
            Menu.Add(new MenuModel() { NamaMenu = "Dimensi Pemetikan" });
            Menu.Add(new MenuModel() { NamaMenu = "Dimensi Pupuk" });
            Menu.Add(new MenuModel() { NamaMenu = "Dimensi Tanah" });
            menu.Add(new MenuModel() { NamaMenu = "Dimensi Waktu" });
        }

        public void SetFactMenu()
        {
            Menu.Clear();
            Menu.Add(new MenuModel(){NamaMenu = "Fakta Area Produksi"});
            Menu.Add(new MenuModel(){NamaMenu = "Fakta Barang Bahan"});
            Menu.Add(new MenuModel() { NamaMenu = "Fakta Curah Hujan" });
            Menu.Add(new MenuModel() { NamaMenu = "Fakta Dawungan" });
            Menu.Add(new MenuModel() { NamaMenu = "Fakta Fungisida Penyakit" });
            Menu.Add(new MenuModel() { NamaMenu = "Fakta Inteksida Hama" });
            Menu.Add(new MenuModel() { NamaMenu = "Fakta Konsensi" });
            Menu.Add(new MenuModel() { NamaMenu = "Fakta Pemangkasan" });
            Menu.Add(new MenuModel() { NamaMenu = "Fakta Pemupukan" });
            Menu.Add(new MenuModel() { NamaMenu = "Fakta Pengendalian Hama" });
            Menu.Add(new MenuModel() { NamaMenu = "Fakta Pengendalian Penyakit" });
            Menu.Add(new MenuModel() { NamaMenu = "Fakta Penyiangan" });
            Menu.Add(new MenuModel() { NamaMenu = "Fakta Produksi" });
            Menu.Add(new MenuModel() { NamaMenu = "Fakta Semprot Hama" });
            Menu.Add(new MenuModel() { NamaMenu = "Fakta Semprot Penyakit" });
            Menu.Add(new MenuModel() { NamaMenu = "Fakta Serangan Hama" });
            Menu.Add(new MenuModel(){NamaMenu = "Fakta Serangan Penyakit"});
            Menu.Add(new MenuModel() { NamaMenu = "Fakta Target Produksi" });
        }

        public void SetOlap()
        {
            Menu.Clear();
            Menu.Add(new MenuModel() { NamaMenu = "Areal Prduksi" });
            Menu.Add(new MenuModel() { NamaMenu = "Barang Bahan" });
            Menu.Add(new MenuModel() { NamaMenu = "Curah Hujan" }); 
            Menu.Add(new MenuModel() { NamaMenu = "Dawungan" });
            Menu.Add(new MenuModel() { NamaMenu = "Fungisida Penyakit" });
            Menu.Add(new MenuModel() { NamaMenu = "Inteksida Hama" });
            Menu.Add(new MenuModel() { NamaMenu = "Konsensi" });
            Menu.Add(new MenuModel() { NamaMenu = "Pemangkasan" });
            Menu.Add(new MenuModel() { NamaMenu = "Pemupukan" });
            Menu.Add(new MenuModel() { NamaMenu = "Pengendalian Hama" });
            Menu.Add(new MenuModel() { NamaMenu = "Pengendalian Penyakit" });
            Menu.Add(new MenuModel() { NamaMenu = "Penyiangan" });
            Menu.Add(new MenuModel() { NamaMenu = "Produksi" });
            Menu.Add(new MenuModel() { NamaMenu = "Semprot Hama" });
            Menu.Add(new MenuModel() { NamaMenu = "Semprot Penyakit" });
            Menu.Add(new MenuModel() { NamaMenu = "Serangan Hama" });
            Menu.Add(new MenuModel() { NamaMenu = "Serangan Penyakit" });
            Menu.Add(new MenuModel() { NamaMenu = "Target Produksi" });
        }

    }
}
