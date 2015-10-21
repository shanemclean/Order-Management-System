using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderManagementSystem.Repository;

namespace OrderManagementSystem.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Customer(int id)
        {
            ViewBag.Message = "Your contact page.";

            var context = new OMSContext();
            var customer = context.Customers.FirstOrDefault(c => c.Id == id);

            return View(customer);
        }
    }
}