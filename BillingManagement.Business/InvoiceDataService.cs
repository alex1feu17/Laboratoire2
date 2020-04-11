using app_models;
using BillingManagement.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace BillingManagement.Business
{
    public class InvoiceDataService : IDataService<Invoice>
    {
        List<Invoice> invoices;
        List<Customer> customers;

        public InvoiceDataService(CustomersDataService Customer)
        {
            customers = Customer.GetAll().ToList();

            Random rnd = new Random();
            foreach (Customer c in customers)
            {
                c.Invoice = new ObservableCollection<Invoice>();
                int nbCustomer = rnd.Next(20, 26);

                for (int i = 0; i < nbCustomer; i++)
                {
                    var invoice = new Invoice(customers);
                    invoice.Customer = c;
                    c.Invoice.Add(invoice);

                    int customerIndex = rnd.Next();

                    if (customers[customerIndex].Invoice == null)
                    {
                        customers[customerIndex].Invoice = new ObservableCollection<Invoice>;

                    }
                    customers[customerIndex].Invoice.Add(invoice);
                    invoice.Customer = customers[customerIndex];
                }
            }
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
