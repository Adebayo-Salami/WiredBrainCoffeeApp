using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using WiredBrainCoffee.CustomerApp.Model;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace WiredBrainCoffee.CustomerApp.Controls
{
    [ContentProperty(Name = nameof(Customer))]
    public sealed partial class CustomerDetailControl : UserControl
    {
        //private Customer _customer;
        // Using a DependencyProperty as the backing store for Customer.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CustomerProperty =
            DependencyProperty.Register("Customer", typeof(Customer), typeof(CustomerDetailControl), new PropertyMetadata(null, CustomerChangedCallback));

        public CustomerDetailControl()
        {
            this.InitializeComponent();
        }

        public Customer Customer
        {
            get { return (Customer)GetValue(CustomerProperty); }
            set { SetValue(CustomerProperty, value); }
        }

        private static void CustomerChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if(d is CustomerDetailControl customerDetailControl)
            {
                var customer = e.NewValue as Customer;
                customerDetailControl.txtFirstName.Text = customer?.Firstname ?? "";
                customerDetailControl.txtLastName.Text = customer?.Lastname ?? "";
                customerDetailControl.chkIsDeveloper.IsChecked = customer?.IsDeveloper;
            }
        }



        //public Customer Customer
        //{
        //    get { return _customer; }
        //    set 
        //    { 
        //        _customer = value;
        //        txtFirstName.Text = _customer?.Firstname ?? "";
        //        txtLastName.Text = _customer?.Lastname ?? "";
        //        chkIsDeveloper.IsChecked = _customer?.IsDeveloper;
        //    }
        //}


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateCustomer();
        }

        private void CheckBox_IsCheckChanged(object sender, RoutedEventArgs e)
        {
            UpdateCustomer();
        }

        private void UpdateCustomer()
        {
            if (Customer != null)
            {
                Customer.Firstname = txtFirstName.Text;
                Customer.Lastname = txtLastName.Text;
                Customer.IsDeveloper = chkIsDeveloper.IsChecked.GetValueOrDefault();
            }
        }
    }
}
