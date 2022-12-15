using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KurlarMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            using (KurServis.KurServisClient servisClient = new KurServis.KurServisClient())
            {
                if(TempData["Kurlar"]!=null)
                {
                    ViewBag.Kurlar = (List<double>)TempData["Kurlar"];
                }
                else
                {
                    ViewBag.Kurlar = new List<double>();
                }
                var model = servisClient.paraBirimleriGetir().ToList();
                return View(model);
            }
            
        }

        public ActionResult KurGetir(string paraBirimi)
        {
            using (KurServis.KurServisClient servisClient = new KurServis.KurServisClient())
            {
                var model = servisClient.KurlariGetir(paraBirimi).ToList();

                TempData["Kurlar"] = model;

                return RedirectToAction("Index");
            }
        }
    }
}