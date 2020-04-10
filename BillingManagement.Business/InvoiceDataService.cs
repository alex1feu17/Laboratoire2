using app_models;
using BillingManagement.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingManagement.Business
{
    public class InvoiceDataService : IDataService<Invoice>
    {
        List<Invoice> invoices;
        List<Customer> customers;

        public InvoiceDataService(CustomersDataService Customer)
        {
            customers = Customer.GetAll().ToList();
            //25:07 video pour continuer.
        }
        public IEnumerable<Invoice> GetAll()
        {
            foreach (Invoice i in invoices)
            {
                yield return i;
            }
        }
    }
}
