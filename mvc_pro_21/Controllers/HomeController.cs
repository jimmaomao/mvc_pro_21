using mvc_pro_21.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_pro_21.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Fruits = new string[] {"Apple","Orange","Pear" };
            ViewBag.Cities = new string[] { "New York", "London","Paris"};
            string message = "This is an html element:<input>";
            return View((object)message);
        }

        public ActionResult CreatePerson() {
            return View(new Person());
        }

        [HttpPost]
        public ActionResult GreatePerson(Person person) {
            return View(person);
        }
    }
}