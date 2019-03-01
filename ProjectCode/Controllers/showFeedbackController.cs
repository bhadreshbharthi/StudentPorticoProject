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
    public class showFeedbackController : Controller
    {
        private dbStudentEntities db = new dbStudentEntities();

        // GET: showFeedback
        public ActionResult Index()
        {
            return View(db.feedbackmasters.ToList());
        }

        // GET: showFeedback/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            feedbackmaster feedbackmaster = db.feedbackmasters.Find(id);
            if (feedbackmaster == null)
            {
                return HttpNotFound();
            }
            return View(feedbackmaster);
        }

        // GET: showFeedback/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: showFeedback/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "fid,fdesc,fdate,fitme,femailid")] feedbackmaster feedbackmaster)
        {
            if (ModelState.IsValid)
            {
                db.feedbackmasters.Add(feedbackmaster);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(feedbackmaster);
        }

        // GET: showFeedback/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            feedbackmaster feedbackmaster = db.feedbackmasters.Find(id);
            if (feedbackmaster == null)
            {
                return HttpNotFound();
            }
            return View(feedbackmaster);
        }

        // POST: showFeedback/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "fid,fdesc,fdate,fitme,femailid")] feedbackmaster feedbackmaster)
        {
            if (ModelState.IsValid)
            {
                db.Entry(feedbackmaster).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(feedbackmaster);
        }

        // GET: showFeedback/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            feedbackmaster feedbackmaster = db.feedbackmasters.Find(id);
            if (feedbackmaster == null)
            {
                return HttpNotFound();
            }
            return View(feedbackmaster);
        }

        // POST: showFeedback/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            feedbackmaster feedbackmaster = db.feedbackmasters.Find(id);
            db.feedbackmasters.Remove(feedbackmaster);
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
