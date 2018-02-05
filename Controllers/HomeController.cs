using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Cds.Models;

namespace Project.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public ActionResult Form()
        {
            return View();
        }

        [HttpPost("/list/clear")]
        public ActionResult Clear()
        {
            Cd.Clear();
            return View();
        }

        [Route("/showStuff")]
        public ActionResult List()
        {
            Cd newCd = new Cd(
                Request.Form["title"],
                Request.Form["artist"],
                Request.Form["price"]
            );
            newCd.Save();

            List<Cd> allCds = Cd.GetAll();
            return View(allCds);
        }
    }
}
