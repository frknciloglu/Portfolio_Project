using Portfolio_Project.Models;
using Portfolio_Project.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio_Project.Controllers
{
    public class ReferenceController : Controller
    {
        // GET: Reference
        PortfolioEntities db=new PortfolioEntities();

        [HttpGet]
        public ActionResult Index()
        {
            var values = db.TblReference.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddReference()
        {
            var values = db.TblReference.ToList();
            return View(values);
        }
        [HttpPost]
        public ActionResult AddReference(TblReference p)
        {
            //db.TblReference.Add(p);
            //db.SaveChanges();
            //return RedirectToAction("Index");
            return View();
        }

        public ActionResult DeleteReference(int id)
        {
            var value = db.TblReference.Find(id);
            db.TblReference.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}