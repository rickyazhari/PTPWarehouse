﻿#pragma checksum "..\..\..\..\views\OLAP\PengendalianPenyakit.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8AE490E442831056559FB0761C47024A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DevExpress.Core;
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.ConditionalFormatting;
using DevExpress.Xpf.Core.DataSources;
using DevExpress.Xpf.Core.Serialization;
using DevExpress.Xpf.Core.ServerMode;
using DevExpress.Xpf.PivotGrid;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace AppWarehouse.views.OLAP {
    
    
    /// <summary>
    /// PengendalianPenyakit
    /// </summary>
    public partial class PengendalianPenyakit : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\..\views\OLAP\PengendalianPenyakit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.PivotGrid.PivotGridControl pivotGridControl;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\views\OLAP\PengendalianPenyakit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Charts.ChartControl chartControl;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\views\OLAP\PengendalianPenyakit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Print;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\views\OLAP\PengendalianPenyakit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Chart;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\views\OLAP\PengendalianPenyakit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pivot;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AppWarehouse;component/views/olap/pengendalianpenyakit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\views\OLAP\PengendalianPenyakit.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.pivotGridControl = ((DevExpress.Xpf.PivotGrid.PivotGridControl)(target));
            return;
            case 2:
            this.chartControl = ((DevExpress.Xpf.Charts.ChartControl)(target));
            return;
            case 3:
            this.Print = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\..\views\OLAP\PengendalianPenyakit.xaml"
            this.Print.Click += new System.Windows.RoutedEventHandler(this.Print_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Chart = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\..\views\OLAP\PengendalianPenyakit.xaml"
            this.Chart.Click += new System.Windows.RoutedEventHandler(this.Chart_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Pivot = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\..\views\OLAP\PengendalianPenyakit.xaml"
            this.Pivot.Click += new System.Windows.RoutedEventHandler(this.Pivot_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

