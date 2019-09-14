using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssessmentTask2V3.Models;

namespace AssessmentTask2V3.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            Console.WriteLine(User.Identity.Name);
            String name = User.Identity.Name;
            CustomerContainer customerContainer = new CustomerContainer();
            Customer customer = new Customer();
            var data = from c in customerContainer.Customers where c.EmailAddress ==
                       name
                       select c;            
            ViewBag.data = data.ToList();
            return View();
        }
    }
}