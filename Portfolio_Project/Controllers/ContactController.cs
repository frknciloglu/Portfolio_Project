using Portfolio_Project.Models.Entities;
using Portfolio_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio_Project.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        
        PortfolioEntities db = new PortfolioEntities();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index(TblMessage p)
        {
            db.TblMessage.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index", "Portfolio");
        }
        [HttpGet]
        public ActionResult Get()
        {
            var values = db.TblContact.ToList();
            return View(values);
        }
    }
}