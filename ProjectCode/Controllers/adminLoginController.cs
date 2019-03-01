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
    public class adminLoginController : Controller
    {
        private  dbStudentEntities db = new dbStudentEntities();
        // GET: adminLogin
        public ActionResult login()
        {
            return View();
        }

        [HttpPost]
        [ActionName("login")]
        public ActionResult loginprocess(string name, string password)
        {
            try
            {
                var data = db.adminMasters.SingleOrDefault(a => a.name == name && a.password == password);
                if(data==null)
                {
                    TempData["Error"] = "Login  Details is Wrong!";
                    return RedirectToAction("login");
                }

                return RedirectToAction("Index", "Dashboard");
            }
            catch (Exception ex)
            {

                TempData["Error"] = ex.Message;
            }
            return View();
        }

    }
}