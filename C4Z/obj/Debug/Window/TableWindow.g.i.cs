﻿#pragma checksum "..\..\..\Window\TableWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B795754586580A818A42FC5F8E7AA0B805B6901A1172C486191F2DC5F7EBA004"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using C4Z;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
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


namespace C4Z {
    
    
    /// <summary>
    /// TableWindow
    /// </summary>
    public partial class TableWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\Window\TableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgEvents;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Window\TableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearchEvent;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Window\TableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton FilterEvent;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\Window\TableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgTypes;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\Window\TableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearchType;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\Window\TableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton FilterType;
        
        #line default
        #line hidden
        
        
        #line 172 "..\..\..\Window\TableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgTags;
        
        #line default
        #line hidden
        
        
        #line 199 "..\..\..\Window\TableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearchTag;
        
        #line default
        #line hidden
        
        
        #line 214 "..\..\..\Window\TableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton FilterTag;
        
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
            System.Uri resourceLocater = new System.Uri("/C4Z;component/window/tablewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Window\TableWindow.xaml"
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
            this.dgEvents = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.tbSearchEvent = ((System.Windows.Controls.TextBox)(target));
            
            #line 54 "..\..\..\Window\TableWindow.xaml"
            this.tbSearchEvent.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchEvent_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 55 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SearchEvent_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 58 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CancelSearchEvent_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.FilterEvent = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            
            #line 85 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditEvent_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 86 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditEvent_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 87 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteEvent_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.dgTypes = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            this.tbSearchType = ((System.Windows.Controls.TextBox)(target));
            
            #line 127 "..\..\..\Window\TableWindow.xaml"
            this.tbSearchType.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchType_TextChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 128 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SearchType_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 131 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CancelSearchType_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.FilterType = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 14:
            
            #line 158 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditType_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 159 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditType_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 160 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteType_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.dgTags = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 18:
            this.tbSearchTag = ((System.Windows.Controls.TextBox)(target));
            
            #line 199 "..\..\..\Window\TableWindow.xaml"
            this.tbSearchTag.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchTag_TextChanged);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 200 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SearchTag_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 203 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CancelSearchTag_Click);
            
            #line default
            #line hidden
            return;
            case 21:
            this.FilterTag = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 22:
            
            #line 230 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditTag_Click);
            
            #line default
            #line hidden
            return;
            case 23:
            
            #line 231 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditTag_Click);
            
            #line default
            #line hidden
            return;
            case 24:
            
            #line 232 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteTag_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

