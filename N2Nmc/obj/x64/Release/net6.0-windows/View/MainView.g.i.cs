﻿#pragma checksum "..\..\..\..\..\View\MainView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "577900EB6548BC240C705B886801266549A89872"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using HandyControl.Controls;
using N2Nmc;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace n2nmc.View {
    
    
    /// <summary>
    /// MainView
    /// </summary>
    public partial class MainView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button guanbi;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button zuixiaohua;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button page1to;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button page2to;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button page3to;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button page4to;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl mainContent;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Framez;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/N2Nmc;V1.0.0.0;component/view/mainview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\MainView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 36 "..\..\..\..\..\View\MainView.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.WinMove_main);
            
            #line default
            #line hidden
            return;
            case 2:
            this.grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.guanbi = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\..\View\MainView.xaml"
            this.guanbi.Click += new System.Windows.RoutedEventHandler(this.Buttonguanbi_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.zuixiaohua = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\..\View\MainView.xaml"
            this.zuixiaohua.Click += new System.Windows.RoutedEventHandler(this.Buttonzuixiaohua_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.page1to = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\..\..\View\MainView.xaml"
            this.page1to.Click += new System.Windows.RoutedEventHandler(this.Page1Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.page2to = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\..\..\..\View\MainView.xaml"
            this.page2to.Click += new System.Windows.RoutedEventHandler(this.Page2Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.page3to = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\..\..\View\MainView.xaml"
            this.page3to.Click += new System.Windows.RoutedEventHandler(this.Page3Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.page4to = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\..\..\..\View\MainView.xaml"
            this.page4to.Click += new System.Windows.RoutedEventHandler(this.Page5Button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 106 "..\..\..\..\..\View\MainView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Buttonset_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.mainContent = ((System.Windows.Controls.ContentControl)(target));
            return;
            case 11:
            this.Framez = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

