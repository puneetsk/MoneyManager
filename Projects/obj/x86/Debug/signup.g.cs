﻿#pragma checksum "C:\Users\punee\Documents\Visual Studio 2015\Projects\Projects\Projects\signup.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D0217510036DE70E8F93464C63BF0D59"
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
    partial class signup : 
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
                    this.SignupPanel = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.SignupTitlePanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3:
                {
                    this.SignupContentPanel = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4:
                {
                    this.txtbsignup = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.susername = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6:
                {
                    this.spassword = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7:
                {
                    this.semail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8:
                {
                    this.ssignup = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 43 "..\..\..\signup.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ssignup).Click += this.ssignup_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.sloginButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 41 "..\..\..\signup.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.sloginButton).Click += this.sloginButton_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.ApplicationTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

