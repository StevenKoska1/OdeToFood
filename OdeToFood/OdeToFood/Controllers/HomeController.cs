﻿using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {

        OdeToFoodDb _db = new OdeToFoodDb();

        public ActionResult Index(string searchTerm=null)
        {


            var model = _db.Restaurants.OrderByDescending(r => r.Reviews.Average(review => review.Rating))
                .Where(r => searchTerm == null || r.Name.StartsWith(searchTerm))
                .Take(10)
                .Select(r => new RestaurantListViewModel
                {
                    Id = r.Id,
                    Name = r.Name,
                    City = r.City,
                    Country = r.Country,
                    CountOfReviews = r.Reviews.Count()
                }
                );

            return View(model);
        }

        public ActionResult About()
        {
            var Model = new AboutModel();
            Model.Name = "Steven";
            Model.Location = "Tallinn, Estonia";
            Model.Age = 19;

            return View(Model);

            
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}