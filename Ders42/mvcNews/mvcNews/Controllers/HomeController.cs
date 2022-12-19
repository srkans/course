using mvcNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcNews.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            using (mvcHaberDB dataBase = new mvcHaberDB())
            {
                indexModel model = new indexModel();
                List<Haber> haberListesi;
                if (TempData["haberler"] != null)
                {

                     haberListesi = (List<Haber>)TempData["haberler"]; // TempData kullanımına dikkat ViewBag  oku!
                }
                else
                {
                     haberListesi = new List<Haber>();
                }

                model.Kategoriler = dataBase.Kategori.ToList();
                model.Haberler = haberListesi;
              //  var model = dataBase.Kategori.ToList();
                return View(model);
            }
            
        }

        public ActionResult HaberleriListele(string SecilenKategori)
        {
            using(mvcHaberDB dataBase = new mvcHaberDB())
            {
                var haberListesi = dataBase.Haber.Include("Yorumlar").Where(hb => hb.Kategori.kategoriAdi == SecilenKategori).ToList(); //include
                TempData["haberler"] = haberListesi;
                return RedirectToAction("Index");
            }
        }

        public ActionResult HaberDetay(int haberID)
        {
            using (mvcHaberDB dataBase = new mvcHaberDB())
            {
                Haber model = dataBase.Haber.Include("Yorumlar").Where(hbr => hbr.Id == haberID).FirstOrDefault();
                return View(model);
            }
        }
        public void dataDoldur()
        {
            using (mvcHaberDB dataBase = new mvcHaberDB()) //anlık çok sayıda kullanıcı gelmesi durumunda oluşturulan yapıyı kullanıldıktan sonra hemen kaldırıyor.                                    
            {                                              //direkt olarak çağırmış olsaydık garbage collector çalıştıktan sonra kaldırılacaktı 
                                                           //using ile kullan diğer şekilde kullanma
                Kategori kategori1 = new Kategori();
                kategori1.kategoriAdi = "Spor";
                dataBase.Kategori.Add(kategori1);
                Kategori kategori2 = new Kategori();
                kategori2.kategoriAdi = "Ekonomi";
                dataBase.Kategori.Add(kategori2);
                Kategori kategori3 = new Kategori();
                kategori3.kategoriAdi = "Magazin";
                dataBase.Kategori.Add(kategori3);
                Kategori kategori4 = new Kategori();
                kategori4.kategoriAdi = "Haber";
                dataBase.Kategori.Add(kategori4);

                Yorum yorum1 = new Yorum();
                yorum1.Icerik = "dün akşamki maç güzeldi";
                yorum1.Tarih = DateTime.Today;
                dataBase.Yorum.Add(yorum1);
                Yorum yorum2 = new Yorum();
                yorum2.Icerik = "paran mı var derdin var";
                yorum2.Tarih = DateTime.Today;
                dataBase.Yorum.Add(yorum2);
                Yorum yorum3 = new Yorum();
                yorum3.Icerik = "Engin hangi ünlüyle yakalandı";
                yorum3.Tarih = DateTime.Today;
                dataBase.Yorum.Add(yorum3);
                Yorum yorum4 = new Yorum();
                yorum4.Icerik = "Fenerbahçe şampiyon";
                yorum4.Tarih = DateTime.Today;
                dataBase.Yorum.Add(yorum4);

                Haber haber1 = new Haber();
                haber1.Baslik = "Yine yendik";
                haber1.Detay = "Türkiye Almanya karşısında yine mutlak zafere ulaştı";
                haber1.Kategori = kategori1;
                haber1.Yorumlar = new List<Yorum>();
                haber1.Yorumlar.Add(yorum1);
                haber1.Yorumlar.Add(yorum4);
                dataBase.Haber.Add(haber1);

                Haber haber2 = new Haber();
                haber2.Baslik = "Akşam eğlencesi";
                haber2.Detay = "Ünlüler dün akşam yine eğlendi";
                haber2.Kategori = kategori3;
                haber2.Yorumlar = new List<Yorum>();
                haber2.Yorumlar.Add(yorum3);              
                dataBase.Haber.Add(haber2);

                Haber haber3 = new Haber();
                haber3.Baslik = "Parası Olan Düşünsün";
                haber3.Detay = "Özel jet fiyatları arttı";
                haber3.Kategori = kategori2;
                haber3.Yorumlar = new List<Yorum>();
                haber3.Yorumlar.Add(yorum2);
                dataBase.Haber.Add(haber3);



                dataBase.SaveChanges(); // yukarıda yazılanların database'e kaydedilmesini sağlıyor.
            }
        }


    }
}