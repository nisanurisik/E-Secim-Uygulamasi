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
    public class KullaniciController : Controller
    {
        UnitOfWork unitOfWork;
        public KullaniciController()
        {
            unitOfWork = new UnitOfWork();
        }

        // GET: KullaniciVontroller
        public ActionResult Index()
        {
            var kullanicilar = unitOfWork.GetRepository<Kullanicilar>().GetAll();
            return View(kullanicilar);
        }
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public JsonResult EkleJson(string kullaniciAd, string kullaniciSoyad, string kullaniciTc, DateTime kullaniciDogum,  string kullaniciYetki, string kullaniciOy, string kullaniciSifre, string kullaniciGirisAdi)
        {
            if (!string.IsNullOrEmpty(kullaniciAd) && !string.IsNullOrEmpty(kullaniciSoyad) && !string.IsNullOrEmpty(kullaniciTc) && kullaniciDogum != null && !string.IsNullOrEmpty(kullaniciYetki) && !string.IsNullOrEmpty(kullaniciOy) && !string.IsNullOrEmpty(kullaniciSifre) && !string.IsNullOrEmpty(kullaniciGirisAdi))
            {
                Kullanicilar kullanici = new Kullanicilar();
                kullanici.KullaniciAdi = kullaniciAd;
                kullanici.KullaniciSoyadi = kullaniciSoyad;
                kullanici.KullaniciTc = kullaniciTc;
                kullanici.KullaniciDogumTarihi = kullaniciDogum;
                
                kullanici.KullaniciYetki = kullaniciYetki;
                kullanici.KullaniciOyDurumu = kullaniciOy;
                kullanici.KullaniciSifre = kullaniciSifre;
                kullanici.KullaniciGirisAdi = kullaniciGirisAdi;
                unitOfWork.GetRepository<Kullanicilar>().Add(kullanici);
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