﻿#pragma checksum "..\..\..\pages\UserPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F266C0E44EDA2ABD5DE8A0C214CE558E3D51EB31BFABC90BA008FAA85959E3C4"
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
using WpfApp1.pages;


namespace WpfApp1.pages {
    
    
    /// <summary>
    /// UserPage
    /// </summary>
    public partial class UserPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\pages\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxSearch;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\pages\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbSorting;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\pages\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckDriver;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\pages\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListUser;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/pages/userpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\pages\UserPage.xaml"
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
            this.TextBoxSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\..\pages\UserPage.xaml"
            this.TextBoxSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CmbSorting = ((System.Windows.Controls.ComboBox)(target));
            
            #line 28 "..\..\..\pages\UserPage.xaml"
            this.CmbSorting.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbSorting_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CheckDriver = ((System.Windows.Controls.CheckBox)(target));
            
            #line 36 "..\..\..\pages\UserPage.xaml"
            this.CheckDriver.Checked += new System.Windows.RoutedEventHandler(this.CheckDriver_Checked);
            
            #line default
            #line hidden
            
            #line 36 "..\..\..\pages\UserPage.xaml"
            this.CheckDriver.Unchecked += new System.Windows.RoutedEventHandler(this.CheckDriver_Unchecked);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 41 "..\..\..\pages\UserPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonClear_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ListUser = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

