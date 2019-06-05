using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StarWars.Models;

namespace StarWars.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Person(int i)
        {
            Person person = StarWarsDAL.GetPerson(i);
            return View(person);
            //return View(StarWarsDAL.GetPerson(i));
        }

        public ActionResult Planet(int i)
        {
            return View(StarWarsDAL.GetPlanet(i));
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
    }
}