﻿#pragma checksum "..\..\CageInfo.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6A7B541372F6335A836017584A3B5C9D892717041F46322A6F3A54807EEADA9A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BirdsControl;
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


namespace BirdsControl {
    
    
    /// <summary>
    /// CageInfo
    /// </summary>
    public partial class CageInfo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\CageInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SerialNumber_tb;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\CageInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Height_tb;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\CageInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Width_tb;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\CageInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Length_tb;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\CageInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gridCage;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\CageInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoadBirds_btn;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\CageInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HomePage_btn;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\CageInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\CageInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Material_tb;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\CageInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back_btn;
        
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
            System.Uri resourceLocater = new System.Uri("/BirdsControl;component/cageinfo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CageInfo.xaml"
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
            this.SerialNumber_tb = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.Height_tb = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.Width_tb = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.Length_tb = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.gridCage = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.LoadBirds_btn = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\CageInfo.xaml"
            this.LoadBirds_btn.Click += new System.Windows.RoutedEventHandler(this.LoadBirds_btn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.HomePage_btn = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\CageInfo.xaml"
            this.HomePage_btn.Click += new System.Windows.RoutedEventHandler(this.HomePage_btn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.Material_tb = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.Back_btn = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\CageInfo.xaml"
            this.Back_btn.Click += new System.Windows.RoutedEventHandler(this.Back_btn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
