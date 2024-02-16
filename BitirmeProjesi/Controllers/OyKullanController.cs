using BitirmeProjesi.Data.Model;
using BitirmeProjesi.Data.UnitOfWork;
using BitirmeProjesi.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BitirmeProjesi.Controllers
{
    
    public class OyKullanController : Controller
    {
        // GET: OyKullan
        UnitOfWork unitOfWork;

        public OyKullanController()
        {
            unitOfWork = new UnitOfWork();
        }

        public ActionResult Index()
        {
            ViewBag.Secimler = unitOfWork.GetRepository<Secim>().GetAll();
            ViewBag.Adaylar = unitOfWork.GetRepository<Aday>().GetAll();
            var kullanilanOylar = unitOfWork.GetRepository<OyKullanmaTablosu>().GetAll();
            //return View(kullanilanOylar);
            return View();
        }
        public ActionResult Ekle()
        {
            ViewBag.Oylar = unitOfWork.GetRepository<OyKullanTablo>().GetAll();
            return View();
        }
        [HttpPost]
        public JsonResult EkleJson(int secimId, int adayId)
        {
            if (secimId != null && adayId != null)
            {
                OyKullanTablo o = new OyKullanTablo();
                o.SecimId = secimId;
                o.AdayId = adayId;
                unitOfWork.GetRepository<OyKullanTablo>().Add(o);
                var durum = unitOfWork.SaveChanges();
                if (durum > 0)
                { return Json("1"); }

                else
                { return Json("0"); }

            }
            else
            {
                return Json("bosOlmamalı");
            }

        }

    }
}