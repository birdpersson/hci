﻿#pragma checksum "..\..\..\Window\TableWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "27D4EC74B5CBD67E70232715133575754EAD6BD37BC054A34835854F0DC19782"
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
        
        
        #line 53 "..\..\..\Window\TableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearchEvent;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\Window\TableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgTypes;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\Window\TableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearchType;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\..\Window\TableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgTags;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\..\Window\TableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearchTag;
        
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
            
            #line 53 "..\..\..\Window\TableWindow.xaml"
            this.tbSearchEvent.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchEvent_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 54 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SearchEvent_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 57 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CancelSearchEvent_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 73 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditEvent_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 74 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditEvent_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 75 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteEvent_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.dgTypes = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.tbSearchType = ((System.Windows.Controls.TextBox)(target));
            
            #line 114 "..\..\..\Window\TableWindow.xaml"
            this.tbSearchType.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchType_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 115 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SearchType_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 118 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CancelSearchType_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 134 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditType_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 135 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditType_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 136 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteType_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.dgTags = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 16:
            this.tbSearchTag = ((System.Windows.Controls.TextBox)(target));
            
            #line 174 "..\..\..\Window\TableWindow.xaml"
            this.tbSearchTag.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchTag_TextChanged);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 175 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SearchTag_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 178 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CancelSearchTag_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 194 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditTag_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 195 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditTag_Click);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 196 "..\..\..\Window\TableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteTag_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

