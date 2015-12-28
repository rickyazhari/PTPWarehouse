﻿using System;
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
    public partial class LuasArealProduksi : UserControl
    {
        private string vis = "pivot";
        public LuasArealProduksi()
        {
                InitializeComponent();
        }

        private void kloonal_Checked(object sender, RoutedEventArgs e)
        {
            dataArea.Caption = "Cloonal";
            dataArea.FieldName = "[Measures].[Cloonal]";
        }

        private void Seeding_Checked(object sender, RoutedEventArgs e)
        {
            dataArea.Caption = "Seeding";
            dataArea.FieldName = "[Measures].[Seeding]";
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

    }
}