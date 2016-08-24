using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyProjectMyBlog.Models;
using MyProjectMyBlog.ViewModels;

namespace MyProjectMyBlog.Controllers
{
    public class ArtistsController : Controller
    {
        // GET: Artists/Random
        public ActionResult Random()
        {
            var artists = new Artists() { Name = "Skrillex", Age = 28, From = "US,California" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1" },
                new Customer {Name = "Customer 2" }
            };
            var viewModel = new RandomArtistViewModel
            {
                Artist = artists,
                Customers = customers
            };

            return View(viewModel);
        }
       
    }
}