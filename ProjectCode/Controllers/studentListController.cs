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
    public class studentListController : Controller
    {
        private dbStudentEntities db = new dbStudentEntities();

        // GET: studentList
        public ActionResult Index()
        {
            return View(db.studentMasters.ToList());
        }

        // GET: studentList/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            studentMaster studentMaster = db.studentMasters.Find(id);
            if (studentMaster == null)
            {
                return HttpNotFound();
            }
            return View(studentMaster);
        }

        // GET: studentList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: studentList/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "sid,sname,fname,lname,emailid,password,gender,image,college,country,state,city")] studentMaster studentMaster)
        {
            if (ModelState.IsValid)
            {
                db.studentMasters.Add(studentMaster);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studentMaster);
        }

        // GET: studentList/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            studentMaster studentMaster = db.studentMasters.Find(id);
            if (studentMaster == null)
            {
                return HttpNotFound();
            }
            return View(studentMaster);
        }

        // POST: studentList/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "sid,sname,fname,lname,emailid,password,gender,image,college,country,state,city")] studentMaster studentMaster)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentMaster).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studentMaster);
        }

        // GET: studentList/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            studentMaster studentMaster = db.studentMasters.Find(id);
            if (studentMaster == null)
            {
                return HttpNotFound();
            }
            return View(studentMaster);
        }

        // POST: studentList/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            studentMaster studentMaster = db.studentMasters.Find(id);
            db.studentMasters.Remove(studentMaster);
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
