﻿#pragma checksum "..\..\ChatE.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "67D9831805A8F46EB22FF632100120E951AFDB6B98DED65946ED3A75B656AF61"
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
    /// Chat
    /// </summary>
    public partial class Chat : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\ChatE.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbUserNameChat;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\ChatE.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbChat;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\ChatE.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbMsg;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\ChatE.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bConnDisc;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\ChatE.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_PersonalEmployer;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\ChatE.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_CreateVacancy;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\ChatE.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_DialoguesWorker;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\ChatE.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_MainWindow;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\ChatE.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_MyVacancy;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\ChatE.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_Login;
        
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
            System.Uri resourceLocater = new System.Uri("/ChatClient;component/chate.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ChatE.xaml"
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
            
            #line 8 "..\..\ChatE.xaml"
            ((ChatClient.Chat)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\ChatE.xaml"
            ((ChatClient.Chat)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbUserNameChat = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.lbChat = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            this.tbMsg = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\ChatE.xaml"
            this.tbMsg.KeyDown += new System.Windows.Input.KeyEventHandler(this.tbMsg_KeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.bConnDisc = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\ChatE.xaml"
            this.bConnDisc.Click += new System.Windows.RoutedEventHandler(this.bConnDisc_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.bt_PersonalEmployer = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\ChatE.xaml"
            this.bt_PersonalEmployer.Click += new System.Windows.RoutedEventHandler(this.bt_PersonalEmployer_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.bt_CreateVacancy = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\ChatE.xaml"
            this.bt_CreateVacancy.Click += new System.Windows.RoutedEventHandler(this.bt_CreateVacancy_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.bt_DialoguesWorker = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\ChatE.xaml"
            this.bt_DialoguesWorker.Click += new System.Windows.RoutedEventHandler(this.bt_DialoguesWorker_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.bt_MainWindow = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\ChatE.xaml"
            this.bt_MainWindow.Click += new System.Windows.RoutedEventHandler(this.bt_MainWindow_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.bt_MyVacancy = ((System.Windows.Controls.Button)(target));
            
            #line 90 "..\..\ChatE.xaml"
            this.bt_MyVacancy.Click += new System.Windows.RoutedEventHandler(this.bt_MyVacancy_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.lb_Login = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

