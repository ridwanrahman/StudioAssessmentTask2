using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssessmentTask2V3.Models;
using System.Web.Security;
using AssessmentTask2V3.Models.CustomerForm;

namespace AssessmentTask2V3.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(CustomerFormModel newCustomer)
        {
            CustomerContainer customer = new CustomerContainer();
            Customer c = new Customer()
            {
                FirstName = newCustomer.FirstName,
                LastName = newCustomer.LastName,
                EmailAddress = newCustomer.EmailAddress,
                Password = newCustomer.Password,
                PhoneNumber = newCustomer.PhoneNumber,
                isActive = "true"
            };
            customer.Customers.Add(c);
            customer.SaveChanges();

            return RedirectToAction("RegisterForwardPage");
        }
        public ActionResult RegisterForwardPage()
        {
            return View();
        }

        public ActionResult Login()
        {   
            return View();
        }

        [HttpPost]
        public ActionResult login(LoginFormModel newLogIn)
        {
            using(var context = new CustomerContainer())
            {
                bool isValid = context.Customers.Any(x => x.EmailAddress == newLogIn.EmailAddress && x.Password == newLogIn.Password);
                if(isValid)
                {
                    FormsAuthentication.SetAuthCookie(newLogIn.EmailAddress, false);
                    return RedirectToAction("Index", "Customer");
                }
            }
            ModelState.AddModelError("", "Invalid username and password");
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}