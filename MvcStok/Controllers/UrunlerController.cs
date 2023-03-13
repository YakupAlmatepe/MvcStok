using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using MvcStok.Models.Entity;

namespace MvcStok.Controllers
{
    public class UrunlerController : Controller
    {
        // GET: Urunler
        MvcDbStokEntities1 db = new MvcDbStokEntities1();
        public ActionResult Index()
        {
           var urunler = db.TBLURUNLER.ToList();
            return View(urunler);
        }
        [HttpGet]
        public ActionResult UrunEkle()
        {
            List<SelectListItem> degerler=(from i in db.TBLKATEGORILER.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.KATEGORIAD,
                                               Value = i.KATEGORYID.ToString()
                                           }).ToList();
            ViewBag.dgr=degerler;
            return View();
        }
        [HttpPost]
        public ActionResult UrunEkle(TBLURUNLER tBLURUNLER)
        {
            var ktg = db.TBLKATEGORILER.Where(x => x.KATEGORYID == tBLURUNLER.TBLKATEGORILER.KATEGORYID).FirstOrDefault();
            tBLURUNLER.TBLKATEGORILER = ktg;
            db.TBLURUNLER.Add(tBLURUNLER);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult SIL(int id)
        {
            var urunler = db.TBLURUNLER.Find(id);
            db.TBLURUNLER.Remove(urunler);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}