using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Cds.Models;

namespace Project.Controllers
{
  public class ArtistController : Controller
  {
    [HttpGet("/artist/search")]
    public ActionResult ArtistSearch()
    {
      return View("ArtistSearch", Cd.GetArtists());
    }


  }
}
