using Portfolio_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio_Project.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        PortfolioEntities db = new PortfolioEntities();

        public ActionResult Index()
        {
            var values = db.TblMessage.ToList();
            return View(values);
        }
        public ActionResult DeleteMessage(int id)
        {
            var value = db.TblMessage.Find(id);
            db.TblMessage.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MessageDetails(int id)
        {
            var value = db.TblMessage.Find(id);
            return View(value);
        }
    }
}