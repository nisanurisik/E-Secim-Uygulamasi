using BitirmeProjesi.Data;
using BitirmeProjesi.Data.Model;
using BitirmeProjesi.Data.UnitOfWork;
using BitirmeProjesi.HelperClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BitirmeProjesi.Controllers
{
    
    public class SecimController : Controller
    {
        UnitOfWork unitOfWork;
        public SecimController()
        {
            unitOfWork = new UnitOfWork();
        }
        // GET: Secim
        public ActionResult Index()
        {
            var secimler = unitOfWork.GetRepository<Secim>().GetAll();
            //Context context = new Context();
            //var model = context.Kullanicilar.ToList();
            return View(secimler);
        }
        
        public ActionResult Ekle()
        {
            ViewBag.Secimler = unitOfWork.GetRepository<Secim>().GetAll();
            return View();
        }
        [YetkiKontrolSistemi]
        [HttpPost]
        public JsonResult EkleJson(string secimAd, DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            if (!string.IsNullOrEmpty(secimAd) && baslangicTarihi != null && bitisTarihi != null)
            {
                Secim secim = new Secim();
                secim.SecimAdi = secimAd;
                secim.SecimBaslangic = baslangicTarihi;
                secim.SecimBitis = bitisTarihi;
                unitOfWork.GetRepository<Secim>().Add(secim);
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