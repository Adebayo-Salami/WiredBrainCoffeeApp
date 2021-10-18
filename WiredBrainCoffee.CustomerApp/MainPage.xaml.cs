using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using WiredBrainCoffee.CustomerApp.DataProvider;
using WiredBrainCoffee.CustomerApp.Model;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WiredBrainCoffee.CustomerApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private CustomerDataProvider _customerDataProvider;

        public MainPage()
        {
            InitializeComponent();
            Loaded += MainPage_Loaded;
            App.Current.Suspending += App_Suspending;
            _customerDataProvider = new CustomerDataProvider();
            RequestedTheme = App.Current.RequestedTheme == ApplicationTheme.Dark ? ElementTheme.Dark : ElementTheme.Light;
        }

        private async void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            customerListView.Items.Clear();
            var customers = await _customerDataProvider.LoadCustomersAsync();
            foreach (var customer in customers)
                customerListView.Items.Add(customer);
        }

        private async void App_Suspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            await _customerDataProvider.SaveCustomersAsync(customerListView.Items.OfType<Customer>());
            deferral.Complete();
        }

        private void Btn_AddCustomer(object sender, RoutedEventArgs e)
        {
            //var messageDialogue = new MessageDialog("C# -- Customer Added Succesfully!");
            //await messageDialogue.ShowAsync();

            var customer = new Customer { Firstname = "New" };
            customerListView.Items.Add(customer);
            customerListView.SelectedItem = customer;
        }

        private void Btn_DeleteCustomer(object sender, RoutedEventArgs e)
        {
            var customer = (Customer)customerListView.SelectedItem;
            if (customer != null)
                customerListView.Items.Remove(customer);
        }

        private void Btn_MoveClick(object sender, RoutedEventArgs e)
        {
            //int column = (int)customerListGrid.GetValue(Grid.ColumnProperty);
            int column = Grid.GetColumn(customerListGrid);
            int newColumn = column == 0 ? 2 : 0;
            //customerListGrid.SetValue(Grid.ColumnProperty, newColumn);
            Grid.SetColumn(customerListGrid, newColumn);
            moveSymbolIcon.Symbol = newColumn == 0 ? Symbol.Forward : Symbol.Back;
        }

        private void CustomerListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var customer = customerListView.SelectedItem as Customer;
            customerDetailControl.Customer = customer;
            //txtFirstName.Text = customer?.Firstname ?? "";
            //txtLastName.Text = customer?.Lastname ?? "";
            //chkIsDeveloper.IsChecked = customer?.IsDeveloper;
        }

        private void Btn_ToggleTheme(object sender, RoutedEventArgs e)
        {
            RequestedTheme = RequestedTheme == ElementTheme.Dark ? ElementTheme.Light : ElementTheme.Dark;
        }

        //private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    UpdateCustomer();
        //}

        //private void CheckBox_IsCheckChanged(object sender, RoutedEventArgs e)
        //{
        //    UpdateCustomer();
        //}

        //private void UpdateCustomer()
        //{
        //    var customer = customerListView.SelectedItem as Customer;
        //    if (customer != null)
        //    {
        //        customer.Firstname = txtFirstName.Text;
        //        customer.Lastname = txtLastName.Text;
        //        customer.IsDeveloper = chkIsDeveloper.IsChecked.GetValueOrDefault();
        //    }
        //}
    }
}
