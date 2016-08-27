﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyProjectMyBlog.Models;

namespace MyProjectMyBlog.Controllers
{
    public class Artists1Controller : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Artists1
        public ActionResult Index()
        {
            return View(db.Artists.ToList());
        }

        // GET: Artists1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artists artists = db.Artists.Find(id);
            if (artists == null)
            {
                return HttpNotFound();
            }
            return View(artists);
        }

        // GET: Artists1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Artists1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Born In")] Artists artists)
        {
            if (ModelState.IsValid)
            {
                db.Artists.Add(artists);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(artists);
        }

        // GET: Artists1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artists artists = db.Artists.Find(id);
            if (artists == null)
            {
                return HttpNotFound();
            }
            return View(artists);
        }

        // POST: Artists1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,BornIn")] Artists artists)
        {
            if (ModelState.IsValid)
            {
                db.Entry(artists).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(artists);
        }

        // GET: Artists1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artists artists = db.Artists.Find(id);
            if (artists == null)
            {
                return HttpNotFound();
            }
            return View(artists);
        }

        // POST: Artists1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Artists artists = db.Artists.Find(id);
            db.Artists.Remove(artists);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}