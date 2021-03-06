using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Cds.Models;

namespace Project.Controllers
{
    public class HomeController : Controller
    {

        [Route("/add-form")]                            //  <-----  this is the relative url used by form actions. I think.
        public ActionResult Form()
        {
            return View("Form");                //  <-----  this is what determines which view will be passed to user. If no argument,
                                                //          it will use the name of the funciton? WTF?
        }

        [Route("/new")]
        public ActionResult AddItem()
        {
            Cd newCd = new Cd(
                Request.Form["title"],
                Request.Form["artist"],
                Request.Form["price"]
            );
            newCd.Save();
            return View("Form");
        }

        [HttpPost("/clear")]
        public ActionResult ClearList()
        {
            Cd.Clear();
            List<Cd> allCds = Cd.GetAll();
            return View("List", allCds);
    }

        [Route("/")]
        public ActionResult List()
        {
            List<Cd> allCds = Cd.GetAll();
            return View("List", allCds);
        }

        [HttpGet("/artist/result")]
        public ActionResult ArtistResult()
        {
          List<Cd> byArtist = Cd.GetByArtist(Request.Query["artist"]);
          return View("List", byArtist);
        }

        [HttpGet("/artist/result/{artist}")]
        public ActionResult ArtistResult(string artist)
        {
          List<Cd> byArtist = Cd.GetByArtist(artist);
          return View("List", byArtist);
        }
    }
}
