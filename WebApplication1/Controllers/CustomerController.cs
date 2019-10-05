using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer { id = 1, Name = "Checker Toby" },
                new Customer  {id = 2, Name = "Klara Coolrunner"}
            };

            return View(customers);
        }


        public ActionResult Detail(int id)
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer { id = 1, Name = "Checker Toby" },
                new Customer  {id = 2, Name = "Klara Coolrunner"}
            };

            Customer c = customers.FirstOrDefault(x => x.id == id);

            return View(c);
        }
    }
}