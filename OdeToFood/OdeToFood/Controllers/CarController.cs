using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Search(string name, string model)
        {
            return Content("Your car is: " + name + " " + model);
        }
    }
}