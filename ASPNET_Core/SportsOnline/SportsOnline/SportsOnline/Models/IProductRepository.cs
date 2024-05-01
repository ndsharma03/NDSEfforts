using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsOnline.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get;  }
    }

    public class FakeProductRepository : IProductRepository
    {
       // IQueryable<Product> _lstProducts;
        public IQueryable<Product> Products{
            get
            {
                var products=  new List<Product>
                {
                    new Product { Name = "Football", Price = 25 },
                    new Product { Name = "Surf board", Price = 179 },
                    new Product { Name = "Running shoes", Price = 95 }
                }.AsQueryable<Product>();
                return products;
            }
         }
    }
}
