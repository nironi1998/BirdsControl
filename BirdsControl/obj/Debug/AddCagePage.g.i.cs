﻿#pragma checksum "..\..\AddCagePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1083BD6AD7758877745184A4FC0BF6B45A70C838A562541226146B76F8C29BFB"
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
    /// AddCagePage
    /// </summary>
    public partial class AddCagePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\AddCagePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SerialNumber_tb;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AddCagePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Height_tb;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AddCagePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Width_tb;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AddCagePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Length_tb;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AddCagePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddCage_btn;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\AddCagePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gridCage;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\AddCagePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Material_drop;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\AddCagePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
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
            System.Uri resourceLocater = new System.Uri("/BirdsControl;component/addcagepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddCagePage.xaml"
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
            this.SerialNumber_tb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Height_tb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Width_tb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Length_tb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.AddCage_btn = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\AddCagePage.xaml"
            this.AddCage_btn.Click += new System.Windows.RoutedEventHandler(this.AddCage_btn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.gridCage = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.Material_drop = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
