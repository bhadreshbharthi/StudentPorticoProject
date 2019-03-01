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
    public class SearchExamsController : Controller
    {
        private dbStudentEntities db = new dbStudentEntities();

        // GET: SearchExams
        public ActionResult Index()
        {
            return View(db.exammasters.ToList());
        }

        // GET: SearchExams/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            exammaster exammaster = db.exammasters.Find(id);
            if (exammaster == null)
            {
                return HttpNotFound();
            }
            return View(exammaster);
        }

        // GET: SearchExams/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SearchExams/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "eid,ename,edate,subjectname,egroup")] exammaster exammaster)
        {
            if (ModelState.IsValid)
            {
                db.exammasters.Add(exammaster);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(exammaster);
        }

        // GET: SearchExams/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            exammaster exammaster = db.exammasters.Find(id);
            if (exammaster == null)
            {
                return HttpNotFound();
            }
            return View(exammaster);
        }

        // POST: SearchExams/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "eid,ename,edate,subjectname,egroup")] exammaster exammaster)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exammaster).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(exammaster);
        }

        // GET: SearchExams/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            exammaster exammaster = db.exammasters.Find(id);
            if (exammaster == null)
            {
                return HttpNotFound();
            }
            return View(exammaster);
        }

        // POST: SearchExams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            exammaster exammaster = db.exammasters.Find(id);
            db.exammasters.Remove(exammaster);
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
