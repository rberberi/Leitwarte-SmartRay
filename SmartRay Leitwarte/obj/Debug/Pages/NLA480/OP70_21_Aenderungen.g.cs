﻿#pragma checksum "..\..\..\..\Pages\NLA480\OP70_21_Aenderungen.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0A39F5864B3E283FEEAC6C2FFB478B1DF02BB029"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using SmartRay_Leitwarte.Pages.NLA480;
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


namespace SmartRay_Leitwarte.Pages.NLA480 {
    
    
    /// <summary>
    /// OP70_21_Aenderungen
    /// </summary>
    public partial class OP70_21_Aenderungen : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\Pages\NLA480\OP70_21_Aenderungen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Pages\NLA480\OP70_21_Aenderungen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_neue_aenderungen;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Pages\NLA480\OP70_21_Aenderungen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_quittierte_aenderungen;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Pages\NLA480\OP70_21_Aenderungen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_quittieren;
        
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
            System.Uri resourceLocater = new System.Uri("/SmartRay Leitwarte;component/pages/nla480/op70_21_aenderungen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\NLA480\OP70_21_Aenderungen.xaml"
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
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.btn_neue_aenderungen = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\Pages\NLA480\OP70_21_Aenderungen.xaml"
            this.btn_neue_aenderungen.Click += new System.Windows.RoutedEventHandler(this.btn_neue_aenderungen_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_quittierte_aenderungen = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.btn_quittieren = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\..\Pages\NLA480\OP70_21_Aenderungen.xaml"
            this.btn_quittieren.Click += new System.Windows.RoutedEventHandler(this.btn_quittieren_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

