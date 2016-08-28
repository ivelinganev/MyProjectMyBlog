using MyProjectMyBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProjectMyBlog.Controllers
{
    public class ArtistsController : Controller
    {
        // GET: Artists
        public ActionResult Index()
        {
            Artists adele = new Artists();
            adele.FirstName = "Adel";
            adele.LastName = "Robinzon";

            Artists lynda = new Artists();
            lynda.FirstName = "Lynda";
            lynda.LastName = "Herzengraf";

            Artists bieber = new Artists();
            bieber.FirstName = "Justin";
            bieber.LastName = "Bieber";

            List<Artists> artists = new List<Artists>();
            artists.Add(adele);
            artists.Add(lynda);
            artists.Add(bieber);

            return View(artists);
        }
       
    }
}