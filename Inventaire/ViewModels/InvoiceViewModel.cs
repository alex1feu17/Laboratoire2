using BillingManagement.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using BillingManagement.Business;
using System.Text;
using app_models;

namespace BillingManagement.UI.ViewModels
{
    public class InvoicesViewModel:BaseViewModel
    {
        private Customer c;
        readonly InvoiceDataService invoiceDataService = new InvoiceDataService(c);

        private ObservableCollection<Invoice> invoices;

        public ObservableCollection<Invoice> Invoices
        {
            get => invoices;
            private set
            {
                invoices = value;
                OnPropertyChanged();
            }
        }
        public InvoicesViewModel()
        {
            InitValues();
        }

        private void InitValues()
        {
            Invoices = new ObservableCollection<Invoice>(InvoiceDataService.GetAll());
          
        }
    }
}
