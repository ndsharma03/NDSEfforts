using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Data
{
    public static class DBInitializer
    {
        public static void Init(IApplicationBuilder builder)
        {
            ILogger _logger;
            LibraryDBContext _dbContext;
            using (var serviceScope = builder.ApplicationServices.CreateScope())
            {
                //_logger= serviceScope.ServiceProvider.GetService<ILogger>();
                _dbContext = serviceScope.ServiceProvider.GetService<LibraryDBContext>();

                Author[] arr = new Author[]{
                new Author { Name = "Niranjan Sharma" }
               ,new Author { Name = "Pallavi Sharma" } };
                _dbContext.Authors.Add(arr[0]); _dbContext.Authors.Add(arr[1]);
                _dbContext.SaveChanges();
                //_logger.LogInformation("*********************Authors Added ******************");
             
                Customer c1 = new Customer { Name = "Jay Sharma" };
                Customer c2 = new Customer { Name = "Pranamya Sharma" };
                _dbContext.Customers.Add(c1); _dbContext.Customers.Add(c2);
                _dbContext.SaveChanges();
                //_logger.LogInformation("*********************Customer Added ******************");

                Book b1 = new Book() { Title = "Let us C", AuthorId = arr[0].Id ,CustomerId=c1.Id};
                Book b2 = new Book() { Title = "Asp.Net Core in Nutshell", AuthorId = arr[1].Id ,CustomerId=c1.Id};
                _dbContext.Books.Add(b1);_dbContext.Books.Add(b2);
                _dbContext.SaveChanges();
               // _logger.LogInformation("*********************Books Added ******************");
            }
        }
        

    }
}
