﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5FA16E9B4F368911E387391EB4E5211586DB3ED2FDECECB62A83E2E1AC07BBD1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using vesssel_card;
using vesssel_card.Classes;


namespace vesssel_card {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 48 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_searchVesselType;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_searchJournalYear;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_searchLengthType;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_searchLengthValue;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_searchWidth;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_searchSideHeight;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_searchDraught;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_searchDisplacement;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_searchDeadweight;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_searchSpeed;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg_documents;
        
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
            System.Uri resourceLocater = new System.Uri("/vesssel_card;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            
            #line 23 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClickCreate);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tb_searchVesselType = ((System.Windows.Controls.TextBox)(target));
            
            #line 48 "..\..\MainWindow.xaml"
            this.tb_searchVesselType.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_searchTextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tb_searchJournalYear = ((System.Windows.Controls.TextBox)(target));
            
            #line 60 "..\..\MainWindow.xaml"
            this.tb_searchJournalYear.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_searchTextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tb_searchLengthType = ((System.Windows.Controls.TextBox)(target));
            
            #line 72 "..\..\MainWindow.xaml"
            this.tb_searchLengthType.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_searchTextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tb_searchLengthValue = ((System.Windows.Controls.TextBox)(target));
            
            #line 84 "..\..\MainWindow.xaml"
            this.tb_searchLengthValue.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_searchTextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tb_searchWidth = ((System.Windows.Controls.TextBox)(target));
            
            #line 96 "..\..\MainWindow.xaml"
            this.tb_searchWidth.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_searchTextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tb_searchSideHeight = ((System.Windows.Controls.TextBox)(target));
            
            #line 108 "..\..\MainWindow.xaml"
            this.tb_searchSideHeight.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_searchTextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.tb_searchDraught = ((System.Windows.Controls.TextBox)(target));
            
            #line 120 "..\..\MainWindow.xaml"
            this.tb_searchDraught.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_searchTextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.tb_searchDisplacement = ((System.Windows.Controls.TextBox)(target));
            
            #line 132 "..\..\MainWindow.xaml"
            this.tb_searchDisplacement.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_searchTextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.tb_searchDeadweight = ((System.Windows.Controls.TextBox)(target));
            
            #line 144 "..\..\MainWindow.xaml"
            this.tb_searchDeadweight.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_searchTextChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.tb_searchSpeed = ((System.Windows.Controls.TextBox)(target));
            
            #line 156 "..\..\MainWindow.xaml"
            this.tb_searchSpeed.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_searchTextChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.dg_documents = ((System.Windows.Controls.DataGrid)(target));
            
            #line 164 "..\..\MainWindow.xaml"
            this.dg_documents.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.dg_documents_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

