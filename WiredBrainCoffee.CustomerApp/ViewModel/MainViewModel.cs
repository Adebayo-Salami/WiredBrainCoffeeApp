using System.Collections.ObjectModel;
using System.Threading.Tasks;
using WiredBrainCoffee.CustomerApp.DataProvider;
using WiredBrainCoffee.CustomerApp.Model;
using WiredBrainCoffee.CustomerApp.Base;

namespace WiredBrainCoffee.CustomerApp.ViewModel
{
    public class MainViewModel : Obervable
    {
        private ICustomerDataProvider _customerDataProvider;
        public ObservableCollection<Customer> Customers { get; }
        private Customer _selectedCustomer;

        public MainViewModel(ICustomerDataProvider customerDataProvider)
        {
            _customerDataProvider = customerDataProvider;
            Customers = new ObservableCollection<Customer>();
        }

        public Customer SelectedCustomer
        {
            get { return _selectedCustomer; }
            set 
            {
                if (_selectedCustomer != value)
                {
                    _selectedCustomer = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(IsCustomerSelected));
                }
            }
        }

        public bool IsCustomerSelected => SelectedCustomer != null;


        public async Task LoadAsync()
        {
            Customers.Clear();
            var customers = await _customerDataProvider.LoadCustomersAsync();
            foreach (var customer in customers)
                Customers.Add(customer);

            //return Task.CompletedTask;
        }

        public async Task SaveAsync()
        {
            await _customerDataProvider.SaveCustomersAsync(Customers);
        }

        public void AddCustomer()
        {
            //var messageDialogue = new MessageDialog("C# -- Customer Added Succesfully!");
            //await messageDialogue.ShowAsync();

            var customer = new Customer { Firstname = "New" };
            Customers.Add(customer);
            SelectedCustomer = customer;
        }

        public void DeleteCustomer()
        {
            if (SelectedCustomer != null)
                Customers.Remove(SelectedCustomer);
            SelectedCustomer = null;
        }
    }
}
