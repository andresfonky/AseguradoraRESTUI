﻿#pragma checksum "..\..\..\Views\editContracts.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "49950918ECE434E7E9CB68F8D86DFCD0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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


namespace AseguradoraRESTUI {
    
    
    /// <summary>
    /// EditContracts
    /// </summary>
    public partial class EditContracts : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Views\editContracts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblId;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Views\editContracts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CboxId;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Views\editContracts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblIdClient;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Views\editContracts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TxtIdClient;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Views\editContracts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblDate;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Views\editContracts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DateDate;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Views\editContracts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblIdPol;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Views\editContracts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TxtIdPol;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Views\editContracts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAceptar;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Views\editContracts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBorrar;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Views\editContracts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCancelar;
        
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
            System.Uri resourceLocater = new System.Uri("/AseguradoraRESTUI;component/views/editcontracts.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\editContracts.xaml"
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
            
            #line 7 "..\..\..\Views\editContracts.xaml"
            ((AseguradoraRESTUI.EditContracts)(target)).Initialized += new System.EventHandler(this.editContract_initializated);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LblId = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.CboxId = ((System.Windows.Controls.ComboBox)(target));
            
            #line 21 "..\..\..\Views\editContracts.xaml"
            this.CboxId.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CboxIdChange);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LblIdClient = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.TxtIdClient = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.LblDate = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.DateDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.LblIdPol = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.TxtIdPol = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.BtnAceptar = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Views\editContracts.xaml"
            this.BtnAceptar.Click += new System.Windows.RoutedEventHandler(this.btnAceptar_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.BtnBorrar = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Views\editContracts.xaml"
            this.BtnBorrar.Click += new System.Windows.RoutedEventHandler(this.btnBorrar_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.BtnCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\Views\editContracts.xaml"
            this.BtnCancelar.Click += new System.Windows.RoutedEventHandler(this.btnCancelar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

