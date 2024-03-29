﻿using Portfolio_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio_Project.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioEntities db=new PortfolioEntities();
        // GET: Portfolio
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()

        {
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            ViewBag.featureTitle = db.TblFeature.Select(x => x.FeatureTitle).FirstOrDefault();
            ViewBag.featureDescription = db.TblFeature.Select(x => x.FeatureDescription).FirstOrDefault();
            ViewBag.featureImageUrl = db.TblFeature.Select(x => x.FeatureImageUrl).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult MyResume()
        {
            var values = db.TblResume.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialStatistic()
        {
            ViewBag.totalService = db.TblService.Count();
            ViewBag.totalMessage = db.TblMessage.Count();
            ViewBag.totalThanksMessage = db.TblMessage.Where(x => x.MessageSubject == "Teşekkür").Count();
            ViewBag.happyCustomer = 12;
            return PartialView();
        }
        [HttpGet]
        public FileResult Download()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(this.Server.MapPath("/Data/cv-en.pdf"));
            string fileName = "cv-en.pdf";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }
        public PartialViewResult PartialVideo()
        {
            ViewBag.title = db.TblVideo.Select(x => x.Title).FirstOrDefault();
            ViewBag.description = db.TblVideo.Select(x => x.Description).FirstOrDefault();
            ViewBag.video = db.TblVideo.Select(x => x.VideoFrame).FirstOrDefault();
            return PartialView();
        }
    }
}