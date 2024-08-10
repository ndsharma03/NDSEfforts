using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.ComponentModel.DataAnnotations;
using WebApplication1.DataContext;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        AppDataContext context;

        [HttpGet(Name = "test")]
        //[Route("customer")]
        //[Authorize]
        public IAsyncEnumerable<Customer> Get(AppDataContext context)
        {
            this.context = context;

            return context.Customers.Include(cust=>cust.Invoices).ThenInclude(inv=>inv.Items).AsAsyncEnumerable();
     
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            return CreatedAtAction("test", new { Id = emp.Id }, emp);
            ;
        }
    }
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is required")]
        [MinLength(10,ErrorMessage ="Name must be 10 character long")]
        public string Name { get; set; }
    }
}
