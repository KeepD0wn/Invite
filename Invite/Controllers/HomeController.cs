using Invite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Invite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Доброе утро" : "Добрый день";
            return View();
        }

        [HttpGet]
        public ActionResult FormInvite()
        {
            return View();
        }

        [HttpPost]
        public ViewResult FormInvite(Guest guest)
        {
            if (ModelState.IsValid)
                return View("Thanks", guest);
            else
                return View();
        }
    }
}