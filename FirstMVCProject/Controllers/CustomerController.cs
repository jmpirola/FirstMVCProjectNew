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
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult DisplayCustomer(Customer objCustomer )
        {
            /*
                        Customer objCustomer = new Customer();

                       objCustomer.Id = Convert.ToInt16(Request.Form["Id"].ToString());
                       objCustomer.CustomerCode = Request.Form["CustomerCode"].ToString();
                       objCustomer.Amount = Convert.ToDouble(Request.Form["Amount"].ToString()); ;
            */
            return View("DisplayCustomerView", objCustomer);
        }

        public ViewResult FillCustomer()
        {
            return View("FillCustomerView");
        }
    }
}