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
        // verweist auf Views\Customer\Index.cshtml
        public ActionResult Index()
        {
            List<Customer> customers = Getcustomers();

            return View(customers);
        }

        // verweist auf Views\Customer\Detail.cshtml
        public ActionResult Detail(int id)
        {
            List<Customer> customers = Getcustomers();

            Customer c = customers.FirstOrDefault(x => x.id == id);

            return View(c);
        }

        public List<Customer> Getcustomers()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer { id = 1, Name = "Checker Toby", Strasse=  "Haupstr. 4", PLZOrt= "12345 Hauptstadt" },
                new Customer  {id = 2, Name = "Klara Coolrunner", Strasse= "Jacobimarkt 5", PLZOrt="34556 Johannesburg"},
                new Customer {id=3, Name="Harry Heinzel", Strasse=  "Cornelia Schlosser Allee. 4", PLZOrt= "34888 Stockholm"},
                new Customer {id=4, Name="Nadja Nickel", Strasse=  "Marienplatz 13", PLZOrt= "71111 Stuttgart"}
            };

            return customers;


        }
    }
}