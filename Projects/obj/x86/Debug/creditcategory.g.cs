﻿#pragma checksum "C:\Users\punee\Documents\Visual Studio 2015\Projects\Projects\Projects\creditcategory.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "07DA519212AAA5A344DE9740B4BBA45F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projects
{
    partial class creditcategory : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.creditCategory = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.TitlePanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3:
                {
                    this.firstgrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4:
                {
                    this.categoryboxes = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5:
                {
                    this.creditcard = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 50 "..\..\..\creditcategory.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.creditcard).Click += this.creditcard_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.creditcategorys = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7:
                {
                    this.check = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 39 "..\..\..\creditcategory.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.check).Click += this.check_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.cash = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 30 "..\..\..\creditcategory.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.cash).Click += this.cash_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.ApplicationTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.WindowStates = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 11:
                {
                    this.WideState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 12:
                {
                    this.NarrowState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

