using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Data
{
  public interface ICustomerResposity:IRepository<Customer>
    {
        IEnumerable<Customer> GetAllWithBooks();

        Customer GetWithBooks(int id);
    }
}
