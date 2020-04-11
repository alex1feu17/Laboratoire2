﻿using app_models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillingManagement.UI.ViewModels
{
    public class Invoice
    {
        public static int InvoiceId { get; set; }

        public DateTime CreationDateTime { get; }

        public Customer Customer { get; set; }

        public double SubTotal { get; set; }

        public double FedTax { get; set; }

        public double ProvTax { get; set; }

        public double Total { get; set; }

        public Invoice(Customer c)
        {
            CreationDateTime = new DateTime(2020, 4, 8, 1, 37, 0);
            c = Customer;
        }

        
    }
}
