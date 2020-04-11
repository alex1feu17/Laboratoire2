using app_models;
using BillingManagement.Business;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace BillingManagement.UI.ViewModels
{
    public class CustomerViewModel : BaseViewModel
    {
        readonly CustomersDataService customersDataService = new CustomersDataService();
        readonly ContactInfosDataService contactInfosDataService = new ContactInfosDataService();

        private ObservableCollection<Customer> customers;
        private ObservableCollection<ContactInfo> contacts;
        private Customer selectedCustomer;

        public ObservableCollection<Customer> Customers
        {
            get => customers;
            private set
            {
                customers = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<ContactInfo> Contacts
        {
            get => contacts;
            private set
            {
                contacts = value;
                OnPropertyChanged();
            }
        }

        public Customer SelectedCustomer
        {
            get => selectedCustomer;
            set
            {
                selectedCustomer = value;
                OnPropertyChanged();
            }
        }

        public CustomerViewModel()
        {
            InitValues();
        }

        private void InitValues()
        {
            Customers = new ObservableCollection<Customer>(customersDataService.GetAll());
            Contacts =new ObservableCollection<ContactInfo>(contactInfosDataService.GetAll());

            Debug.WriteLine(Customers.Count);
        }

    }
}
