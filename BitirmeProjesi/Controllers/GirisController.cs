using BitirmeProjesi.Data.Model;
using BitirmeProjesi.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BitirmeProjesi.Controllers
{
    public class GirisController : Controller
    {
        private readonly UnitOfWork _unitOfWork;
        public GirisController()
        {
            _unitOfWork = new UnitOfWork();
        }
        // GET: Giris
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult GirisKontrol(string email, string sifre, bool hatirla)
        {
            //email = email.Trim();
            //sifre = sifre.Trim();
            if (string.IsNullOrEmpty(email) && string.IsNullOrEmpty(sifre))
                return Json("BosOlamaz");

            var kullanici = new Kullanicilar();
            try
            {
                kullanici = _unitOfWork.GetRepository<Kullanicilar>().Get(x=>x.KullaniciGirisAdi == email && x.KullaniciSifre == sifre);
            }
            catch
            {

            }
            if (kullanici != null)
            {
                HttpCookie cookie = new HttpCookie("kullanici");
                cookie.Values.Add("KullaniciId", kullanici.KullaniciId.ToString());
                cookie.Values.Add("KullaniciAdi", kullanici.KullaniciAdi);
                cookie.Values.Add("KullaniciSoyadi", kullanici.KullaniciSoyadi);
                cookie.Values.Add("KullaniciYetki", kullanici.KullaniciYetki);

                if (hatirla) cookie.Expires = DateTime.Now.AddDays(5);
                Response.Cookies.Add(cookie);
                return Json("Başarılı");
            }
            else return Json("Hata");
            }
        public ActionResult CikisYap()
        {
            var cookie = Response.Cookies["kullanici"];
            if(cookie != null)
                cookie.Expires = DateTime.Now.AddDays(-1);
            return RedirectToAction("Index");
        
        }
        }
    }
