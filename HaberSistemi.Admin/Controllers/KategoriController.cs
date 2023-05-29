using Autofac.Diagnostics;
using HaberSistemi.Admin.Class;
using HaberSistemi.Core.Infrastructure;
using HaberSistemi.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

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
        [HttpGet]
        public ActionResult Listele()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Ekle() 
        {
            SetKategoriListele();
            return View();
        }
        [HttpPost]
        public JsonResult Ekle(Kategori kategori)
        {
            try
            {
                _kategoriRepository.Insert(kategori);
                _kategoriRepository.Save();
                return Json(new ResultJson { Success = true , Message = "Kategori ekleme işlemeniz başarılı."});
            }
            catch (Exception ex)
            {
                return Json(new ResultJson { Success = false, Message = "Kategori eklerken hata oluştu." });

            }
            
        }
        #region Set Kategori
        public void SetKategoriListele() 
        {
            var  KategoriList = _kategoriRepository.GetMany(x=> x.ParentId == 0).ToList();
            ViewBag.Kategori = KategoriList;

        }
        #endregion

    }
}