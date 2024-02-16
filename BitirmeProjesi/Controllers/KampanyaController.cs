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
    [YetkiKontrolSistemi]
    public class KampanyaController : Controller
    {
        UnitOfWork unitOfWork;
        public KampanyaController()
        {
            unitOfWork = new UnitOfWork();
        }
        // GET: Kampanya
        public ActionResult Index()
        {
            var kampanyalar = unitOfWork.GetRepository<Kampanya>().GetAll();
            return View(kampanyalar);
        }
        public ActionResult Ekle()
        {
            return View();
        }
        
        [HttpPost]
        public JsonResult EkleJson(string kampanyaAd, string adayAdi, string kampanyaMetni)
        {
            if (!string.IsNullOrEmpty(kampanyaAd) && !string.IsNullOrEmpty(adayAdi) && !string.IsNullOrEmpty(kampanyaMetni))
            {
                Kampanya kampanya = new Kampanya();
                kampanya.KampanyaBaslik = kampanyaAd;
                kampanya.KampanyaAday = adayAdi;
                kampanya.KampanyaMetni = kampanyaMetni;
                unitOfWork.GetRepository<Kampanya>().Add(kampanya);
                var durum = unitOfWork.SaveChanges();
                if (durum > 0)
                {
                    return Json("1");
                }
                else
                {
                    return Json("0");
                }

            }
            else
            {
                return Json("bosOlmamalı");
            }
        }
    }
}