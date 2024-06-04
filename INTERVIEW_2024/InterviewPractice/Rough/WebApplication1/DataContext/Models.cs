using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebApplication1.DataContext
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public virtual List<Invoice> Invoices { get; set; }
    }

    public class Invoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }

       
        //[JsonIgnore]
        //public virtual Customer Customer { get; set; }
        public virtual List<InvoiceItem> Items { get; set; }
    }

    public class InvoiceItem
    {
        public int InvoiceItemId { get; set; }
        [ForeignKey("InvoiceId")]
        public int InvoiceId { get; set; }
        public string Code { get; set; }

      
        //[JsonIgnore]
        //public virtual Invoice Invoice { get; set; }
    }
}
