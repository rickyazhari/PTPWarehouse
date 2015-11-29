using AppWarehouse.models;
using AppWarehouse.viewmodel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows;

namespace AppWarehouse
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static EtlViewModel EtlViewModel;

        public static EtlViewModel ETLViewModel
        {
            get {
                if (EtlViewModel == null)
                {
                    EtlViewModel = new EtlViewModel();
                }
                return App.EtlViewModel; }
            set { App.EtlViewModel = value; }
        }

        private static MenuViewModel menuViewModel;

        public static MenuViewModel MenuViewModel
        {
            get
            {
                if (menuViewModel == null)
                {
                    menuViewModel = new MenuViewModel();
                } 
                return App.menuViewModel; }
            set { App.menuViewModel = value; }
        }

        private static OlapViewModel olapViewModel;

        public static OlapViewModel OlapViewModel
        {
            get
            {
                if (olapViewModel == null)
                {
                    olapViewModel = new OlapViewModel();
                } 
                return App.olapViewModel; }
            set { App.olapViewModel = value; }
        }

        private static DimFactViewModel dimfactViewModel;

        public static DimFactViewModel DimfactViewModel
        {
            get {
                if (dimfactViewModel == null)
                {
                    dimfactViewModel = new DimFactViewModel();
                }
                return App.dimfactViewModel; 
            }
            set { App.dimfactViewModel = value; }
        }

    }
}
