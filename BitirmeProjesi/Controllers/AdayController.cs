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
    
    public class AdayController : Controller
    {
        UnitOfWork unitOfWork;
        public AdayController()
        {
            unitOfWork = new UnitOfWork();
        }
        // GET: Aday
        public ActionResult Index()
        {
            var adaylar = unitOfWork.GetRepository<Aday>().GetAll();
            return View(adaylar);
        }
        public ActionResult Ekle()
        {
            ViewBag.Secimler = unitOfWork.GetRepository<Secim>().GetAll();
            ViewBag.Kullanicilar = unitOfWork.GetRepository<Kullanicilar>().GetAll();
            //ViewBag.Adaylar = unitOfWork.GetRepository<Aday>().GetAll();
            return View();
        }
        [YetkiKontrolSistemi]
        [HttpPost]
        public JsonResult EkleJson(int secimId, int kullaniciId, string adayParti)
        {
            if (!string.IsNullOrEmpty(adayParti))
            {
                Aday aday = new Aday();
                aday.SecimId = secimId;
                aday.KullaniciId = kullaniciId;
                aday.AdayParti = adayParti;
                unitOfWork.GetRepository<Aday>().Add(aday);
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