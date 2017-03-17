using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        [Route("customers/index")]
        public ActionResult Index()
        {

            var customers = new List<Customer>
            {
                new Customer { Name = "First one" }
            };

            var viewModel = new CustomerViewModel
            {
                Customers = customers
            };
            return View(viewModel);
        }
        
        
       
    }
}