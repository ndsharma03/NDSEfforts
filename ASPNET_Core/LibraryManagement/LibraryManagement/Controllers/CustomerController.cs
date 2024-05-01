using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryManagement.Controllers
{

    
    public class CustomerController : Controller
    {
        private readonly ICustomerResposity customerRepository;
        public CustomerController(ICustomerResposity customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        [Route("{Controller}/")]
        [Route("{Controller}/{Action}")]
        public IActionResult List()
        {
            IEnumerable<Customer> customers = customerRepository.GetAllWithBooks();
            if (customers?.Count() == 0)
            {
                return View("Empty");
            }
            else
            {
                //If our folder name is different than controller name we can call view like below:
                return View("Views/Customers/List.cshtml",customers);
            }
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
