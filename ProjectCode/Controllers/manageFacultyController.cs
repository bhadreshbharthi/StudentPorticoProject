using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectCode.Models;

namespace ProjectCode.Controllers
{
    public class manageFacultyController : Controller
    {
        private dbStudentEntities db = new dbStudentEntities();

        // GET: manageFaculty
        public ActionResult Index()
        {
            return View(db.facultymasters.ToList());
        }

        // GET: manageFaculty/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            facultymaster facultymaster = db.facultymasters.Find(id);
            if (facultymaster == null)
            {
                return HttpNotFound();
            }
            return View(facultymaster);
        }

        // GET: manageFaculty/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: manageFaculty/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "facid,facname,emailid,password")] facultymaster facultymaster)
        {
            if (ModelState.IsValid)
            {
                db.facultymasters.Add(facultymaster);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(facultymaster);
        }

        // GET: manageFaculty/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            facultymaster facultymaster = db.facultymasters.Find(id);
            if (facultymaster == null)
            {
                return HttpNotFound();
            }
            return View(facultymaster);
        }

        // POST: manageFaculty/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "facid,facname,emailid,password")] facultymaster facultymaster)
        {
            if (ModelState.IsValid)
            {
                db.Entry(facultymaster).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(facultymaster);
        }

        // GET: manageFaculty/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            facultymaster facultymaster = db.facultymasters.Find(id);
            if (facultymaster == null)
            {
                return HttpNotFound();
            }
            return View(facultymaster);
        }

        // POST: manageFaculty/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            facultymaster facultymaster = db.facultymasters.Find(id);
            db.facultymasters.Remove(facultymaster);
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
