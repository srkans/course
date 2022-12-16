using ogrenciKayit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ogrenciKayit.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ogrenciKaydet(string Ad, string soyAd, string Ders, int Not)
        {
            if (HttpRuntime.Cache["ogrenciler"] == null)
            {
                List<Ogrenci> ogrenciListesi = new List<Ogrenci>();

                Ogrenci o = new Ogrenci();

                o.Ad = Ad;
                o.soyAd = soyAd;
                o.Ders = Ders;
                o.Not = Not;

                ogrenciListesi.Add(o);
                HttpRuntime.Cache["ogrenciler"] = ogrenciListesi; //ram'de bi alan açıp bilgileri tutmayı sağlar
            }
            else
            {
                List<Ogrenci> ogrenciListesi = (List<Ogrenci>)HttpRuntime.Cache["ogrenciler"];
                Ogrenci o = new Ogrenci();

                o.Ad = Ad;
                o.soyAd = soyAd;
                o.Ders = Ders;
                o.Not = Not;

                ogrenciListesi.Add(o);
                HttpRuntime.Cache["ogrenciler"] = ogrenciListesi;
            }
            return RedirectToAction("OgrenciListe");

        }

        public ActionResult OgrenciListe()
        {
            var model = (List<Ogrenci>)HttpRuntime.Cache["ogrenciler"]; //unboxing
            return View(model);
        }
    }

}

