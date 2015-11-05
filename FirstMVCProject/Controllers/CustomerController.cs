using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVCProject.Models;

namespace FirstMVCProject.Controllers
{
    public class CustomerController : Controller
    {
        List<Customer> Customers = new List<Customer>();
        //
        // GET: /Customer/
        public CustomerController()
        {
            Customer obj1 = new Customer();
            obj1.Id = 12;
            obj1.CustomerCode = "1001";
            obj1.Amount = 90.34;

            Customers.Add(obj1);

            obj1 = new Customer();
            obj1.Id = 11;
            obj1.CustomerCode = "1002";
            obj1.Amount = 91;
            Customers.Add(obj1);

        }

        [HttpGet]
        public ViewResult DisplayCustomer(int id)
        {
            Customer objCustomer = Customers[id];

            return View("DisplayCustomer", objCustomer);
        }

        [HttpGet]
        public ViewResult FillCustomer()
        {
            

            return View("FillCustomerView");
        }

        [HttpPost]
        public ActionResult PostCustomer(Customer obj)
        {
            if (ModelState.IsValid)
            {
                //obj.Save();
                return View("ThanksView");
            }
            else
            {
                return View("FillCustomerView");
            }
        }
    }
}