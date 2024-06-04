namespace WebApplication1.DataContext
{

        public static class SeedDataGenerator
        {
            public static void Generate(AppDataContext context)
        {
            var customers = GenerateCustomers();
            context.Customers.AddRange(customers);
            var invoices = GenerateInvoices(customers);
            context.Invoices.AddRange(invoices);
            var invoiceItems = GenerateInvoiceItems(invoices);
            context.InvoiceItems.AddRange(invoiceItems);
            context.SaveChanges();



        } 
            public static List<Customer> GenerateCustomers()
            {
                return new List<Customer>
        {
            new Customer
            {
                CustomerId = 1,
                FirstName = "John",
                LastName = "Doe",
                Address = "123 Main St"
            },
            new Customer
            {
                CustomerId = 2,
                FirstName = "Jane",
                LastName = "Smith",
                Address = "456 Elm Ave"
            }
            // Add more customers as needed
        };
            }

            public static List<Invoice> GenerateInvoices(List<Customer> customers)
            {
                return new List<Invoice>
        {
            new Invoice
            {
                Id = 101,
                Date = DateTime.Now.AddDays(-10),
                CustomerId = 1,
                //Customer = customers[0]
            },
            new Invoice
            {
                Id = 102,
                Date = DateTime.Now.AddDays(-5),
                CustomerId = 2,
               // Customer = customers[1]
            }
            // Add more invoices as needed
        };
            }

            public static List<InvoiceItem> GenerateInvoiceItems(List<Invoice> invoices)
            {
                return new List<InvoiceItem>
        {
            new InvoiceItem
            {
                InvoiceItemId = 1001,
                InvoiceId = 101,
                Code = "ABC123",
               // Invoice = invoices[0]
            },
            new InvoiceItem
            {
                InvoiceItemId = 1002,
                InvoiceId = 102,
                Code = "XYZ456",
               // Invoice = invoices[1]
            }
            // Add more invoice items as needed
        };
            }
        }
    
}
