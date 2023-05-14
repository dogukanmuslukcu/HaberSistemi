using HaberSistemi.Core.Infrastructure;
using HaberSistemi.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberSistemi.Admin.Controllers
{
    public class KategoriController : Controller
    {
        #region Kategori
        private readonly IKategoriRepository _kategoriRepository;
        public KategoriController(IKategoriRepository kategoriRepository) 
        {
            _kategoriRepository = kategoriRepository;
        }
        #endregion
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Ekle() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Kategori kategori)
        {
            return Json(1,JsonRequestBehavior.AllowGet);
        }
    }
}