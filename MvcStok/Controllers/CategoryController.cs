using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStok.Models.Entity;


namespace MvcStok.Controllers
{
    public class CategoryController : Controller
    {

        MvcDbStokEntities1 db = new MvcDbStokEntities1();
        public ActionResult Index()
        {
            var deger= db.TBLKATEGORILER.ToList();
           
            return View(deger);
        }
        [HttpGet]
        public ActionResult YeniKategori()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniKategori(TBLKATEGORILER tBLKATEGORILER)
        {
            db.TBLKATEGORILER.Add(tBLKATEGORILER);
            db.SaveChanges();
            return View();
        }
        public ActionResult SIL(int id)
        {
            var kategori = db.TBLKATEGORILER.Find(id);
            db.TBLKATEGORILER.Remove(kategori);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}