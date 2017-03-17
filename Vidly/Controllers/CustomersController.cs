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
        
        public ActionResult CustomersView()
        {

            var customers = new List<Customer>
            {
                new Customer { Name = "First One" },
                new Customer { Name = "Second One" }
            };

            var viewModel = new CustomerViewModel
            {
                Customers = customers
            };
            return View(viewModel);
        }
        
        
       
    }
}