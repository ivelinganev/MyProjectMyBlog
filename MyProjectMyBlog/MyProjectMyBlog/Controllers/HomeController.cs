using MyProjectMyBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;


namespace MyProjectMyBlog.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var db = new ApplicationDbContext();
            var lastestPosts = db.Posts
                .Include(p => p.Auhtor)
                .OrderByDescending(p => p.Date).Take(6);

            return View(lastestPosts.ToList());
           
        }
    }
}