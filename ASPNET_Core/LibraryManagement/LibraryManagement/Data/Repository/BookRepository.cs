using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
namespace LibraryManagement.Data
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(LibraryDBContext context) : base(context)
        {

        }
        public IEnumerable<Book> FindWithAuthor(Func<Book, bool> predicate)
        {
            return context.Books.Include(x => x.Author).Where(predicate);
        }

        public IEnumerable<Book> FindWithAuthorAndCustomer(Func<Book, bool> predicate)
        {
            return context.Books.Include(x => x.Author)
                                .Include(x => x.Customer)
                                .Where(predicate);
        }

        public IEnumerable<Book> GetAllWithAuthor()
        {
            return context.Books.Include(x => x.Author);
        }
    }
}
