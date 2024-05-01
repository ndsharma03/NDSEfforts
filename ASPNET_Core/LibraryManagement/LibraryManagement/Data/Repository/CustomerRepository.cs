using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;
namespace LibraryManagement.Data
{
    public class CustomerRepository : Repository<Customer>, ICustomerResposity
    {
        public CustomerRepository(LibraryDBContext context):base(context)
        {

        }

        public IEnumerable<Customer> GetAllWithBooks()
        {
            return context.Customers.Include(x => x.Books);
        }

        public Customer GetWithBooks(int id)
        {
            return context.Customers.Include(x => x.Books).FirstOrDefault(x => x.Id == id);
        }
    }
}
