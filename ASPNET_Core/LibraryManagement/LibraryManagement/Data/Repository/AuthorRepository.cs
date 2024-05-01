using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Data
{
    public class AuthorRepository: Repository<Author>,IAuthorRepository 
    {
        public AuthorRepository(LibraryDBContext context):base(context)
        {
                
        }

        public IEnumerable<Author> GetAllWithBooks()
        {
            return context.Authors.Include(a => a.Books);
        }

        public Author GetWithBooks(int id)
        {
            return context.Authors.Where(x => x.Id == id)
                    .Include(x => x.Books).FirstOrDefault();
        }
    }
}
