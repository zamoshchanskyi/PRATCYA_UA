﻿#pragma checksum "..\..\ListVacancy.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1BCA6834938CB06E27490D5B5FA3E2555243805949C89327CB31EA137991B9C7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ChatClient;
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


namespace ChatClient {
    
    
    /// <summary>
    /// ListVacancy
    /// </summary>
    public partial class ListVacancy : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 26 "..\..\ListVacancy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_PersonalWorker;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\ListVacancy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_SearchVacancies;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\ListVacancy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_DialoguesWorker;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\ListVacancy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_MainWindow;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\ListVacancy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_NameSurname;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\ListVacancy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_LoginW;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\ListVacancy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridVacancy;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\ListVacancy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn datagridPosition;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\ListVacancy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn datagridSalary;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\ListVacancy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn datagridEmployment;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\ListVacancy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn datagridCity;
        
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
            System.Uri resourceLocater = new System.Uri("/ChatClient;component/listvacancy.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ListVacancy.xaml"
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
            
            #line 8 "..\..\ListVacancy.xaml"
            ((ChatClient.ListVacancy)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 9 "..\..\ListVacancy.xaml"
            ((ChatClient.ListVacancy)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.bt_PersonalWorker = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\ListVacancy.xaml"
            this.bt_PersonalWorker.Click += new System.Windows.RoutedEventHandler(this.bt_PersonalWorker_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.bt_SearchVacancies = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\ListVacancy.xaml"
            this.bt_SearchVacancies.Click += new System.Windows.RoutedEventHandler(this.bt_SearchVacancies_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.bt_DialoguesWorker = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\ListVacancy.xaml"
            this.bt_DialoguesWorker.Click += new System.Windows.RoutedEventHandler(this.bt_DialoguesWorker_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.bt_MainWindow = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\ListVacancy.xaml"
            this.bt_MainWindow.Click += new System.Windows.RoutedEventHandler(this.bt_MainWindow_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lb_NameSurname = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.lb_LoginW = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.dataGridVacancy = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.datagridPosition = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 10:
            this.datagridSalary = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 11:
            this.datagridEmployment = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 12:
            this.datagridCity = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 13:
            
            #line 119 "..\..\ListVacancy.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.bt_Podrobici_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

