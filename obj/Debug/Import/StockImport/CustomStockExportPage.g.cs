﻿#pragma checksum "..\..\..\..\Import\StockImport\CustomStockExportPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "328F584333FDA4BA1F16EFA340D4B619"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// CustomStockExportPage
    /// </summary>
    public partial class CustomStockExportPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 220 "..\..\..\..\Import\StockImport\CustomStockExportPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid CustomStockExportGrid;
        
        #line default
        #line hidden
        
        
        #line 221 "..\..\..\..\Import\StockImport\CustomStockExportPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel upperDockPanel;
        
        #line default
        #line hidden
        
        
        #line 223 "..\..\..\..\Import\StockImport\CustomStockExportPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox companiesComboBox;
        
        #line default
        #line hidden
        
        
        #line 224 "..\..\..\..\Import\StockImport\CustomStockExportPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button calculateButton;
        
        #line default
        #line hidden
        
        
        #line 225 "..\..\..\..\Import\StockImport\CustomStockExportPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button restartThisButton;
        
        #line default
        #line hidden
        
        
        #line 226 "..\..\..\..\Import\StockImport\CustomStockExportPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button restartAllButton;
        
        #line default
        #line hidden
        
        
        #line 228 "..\..\..\..\Import\StockImport\CustomStockExportPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ImportedTransactions_Grid;
        
        #line default
        #line hidden
        
        
        #line 276 "..\..\..\..\Import\StockImport\CustomStockExportPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid exportPreviewGrid;
        
        #line default
        #line hidden
        
        
        #line 329 "..\..\..\..\Import\StockImport\CustomStockExportPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button dataGridChanger;
        
        #line default
        #line hidden
        
        
        #line 330 "..\..\..\..\Import\StockImport\CustomStockExportPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exportButton;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/import/stockimport/customstockexportpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Import\StockImport\CustomStockExportPage.xaml"
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
            this.CustomStockExportGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.upperDockPanel = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 3:
            this.companiesComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.calculateButton = ((System.Windows.Controls.Button)(target));
            
            #line 224 "..\..\..\..\Import\StockImport\CustomStockExportPage.xaml"
            this.calculateButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.restartThisButton = ((System.Windows.Controls.Button)(target));
            
            #line 225 "..\..\..\..\Import\StockImport\CustomStockExportPage.xaml"
            this.restartThisButton.Click += new System.Windows.RoutedEventHandler(this.restartThisButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.restartAllButton = ((System.Windows.Controls.Button)(target));
            
            #line 226 "..\..\..\..\Import\StockImport\CustomStockExportPage.xaml"
            this.restartAllButton.Click += new System.Windows.RoutedEventHandler(this.restartAllButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ImportedTransactions_Grid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 229 "..\..\..\..\Import\StockImport\CustomStockExportPage.xaml"
            this.ImportedTransactions_Grid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ImportedTransactions_Grid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.exportPreviewGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.dataGridChanger = ((System.Windows.Controls.Button)(target));
            
            #line 329 "..\..\..\..\Import\StockImport\CustomStockExportPage.xaml"
            this.dataGridChanger.Click += new System.Windows.RoutedEventHandler(this.dataGridChanger_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.exportButton = ((System.Windows.Controls.Button)(target));
            
            #line 330 "..\..\..\..\Import\StockImport\CustomStockExportPage.xaml"
            this.exportButton.Click += new System.Windows.RoutedEventHandler(this.exportButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

