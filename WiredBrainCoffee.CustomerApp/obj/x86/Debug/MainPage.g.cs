﻿#pragma checksum "C:\Users\osalami\Documents\Applications\WiredBrainCoffee.CustomerApp\WiredBrainCoffee.CustomerApp\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4DF8173810DB64B87FAAF0402D718DB8D697535522B3EA400F72ECB2CD652909"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WiredBrainCoffee.CustomerApp
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 52
                {
                    global::Windows.UI.Xaml.Controls.Button element2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Click += this.Btn_ToggleTheme;
                }
                break;
            case 3: // MainPage.xaml line 56
                {
                    this.customerListGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4: // MainPage.xaml line 80
                {
                    this.customerListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 5: // MainPage.xaml line 63
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Click += this.Btn_MoveClick;
                }
                break;
            case 6: // MainPage.xaml line 66
                {
                    global::Windows.UI.Xaml.Controls.Button element6 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element6).Click += this.Btn_AddCustomer;
                }
                break;
            case 7: // MainPage.xaml line 72
                {
                    global::Windows.UI.Xaml.Controls.Button element7 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element7).Click += this.Btn_DeleteCustomer;
                }
                break;
            case 8: // MainPage.xaml line 64
                {
                    this.moveSymbolIcon = (global::Windows.UI.Xaml.Controls.SymbolIcon)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

