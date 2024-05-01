using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsOnline.Models
{
    public class EFProductRepository : IProductRepository
    {
        ApplicationDBContext context;
        public EFProductRepository(ApplicationDBContext ctx)
        {
            context = ctx;
            context.Database.EnsureCreated();
        }
        public IQueryable<Product> Products => context.Products.AsQueryable<Product>();
    }
}
