﻿#pragma checksum "..\..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "85D8E084700B625A41C6C4DBE66A183D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GoodAdvice;
using HamburgerMenu;
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


namespace GoodAdvice {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GoodAdvice.MainWindow this_;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid mainGrid;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame ContentFrame;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HamburgerMenu.HamburgerMenu hamMenu;
        
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
            System.Uri resourceLocater = new System.Uri("/GoodAdvice;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
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
            this.this_ = ((GoodAdvice.MainWindow)(target));
            return;
            case 2:
            this.mainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.ContentFrame = ((System.Windows.Controls.Frame)(target));
            
            #line 19 "..\..\..\MainWindow.xaml"
            this.ContentFrame.ContentRendered += new System.EventHandler(this.ContentFrame_ContentRendered);
            
            #line default
            #line hidden
            return;
            case 4:
            this.hamMenu = ((HamburgerMenu.HamburgerMenu)(target));
            return;
            case 5:
            
            #line 30 "..\..\..\MainWindow.xaml"
            ((HamburgerMenu.HamburgerMenuItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.HamburgerMenuItem_Selected);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 31 "..\..\..\MainWindow.xaml"
            ((HamburgerMenu.HamburgerMenuItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.HamburgerMenuItem_Selected_1);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 32 "..\..\..\MainWindow.xaml"
            ((HamburgerMenu.HamburgerMenuItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.HamburgerMenuItem_Selected_2);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 33 "..\..\..\MainWindow.xaml"
            ((HamburgerMenu.HamburgerMenuItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.HamburgerMenuItem_Selected_3);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 34 "..\..\..\MainWindow.xaml"
            ((HamburgerMenu.HamburgerMenuItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.HamburgerMenuItem_Selected_4);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

