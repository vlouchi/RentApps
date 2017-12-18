using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentApps.Models;

namespace RentApps.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ViewResult Index()
        {
            var customers = GetCustomers();
            return View(customers);

        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);

        }


        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Id = 1, Name = "Irba Fairuz Thufailah"},
                new Customer {Id = 2, Name = "Sahna Melly Marselina"},
                new Customer {Id = 3, Name = "Intan Raharni Wijaya"},
                new Customer {Id = 4, Name = "Grace Duma Tambunan"}
            };

        }
    }
}