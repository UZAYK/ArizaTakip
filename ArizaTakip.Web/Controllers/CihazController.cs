using ArizaTakip.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ArizaTakip.Entites.Concrete;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ArizaTakip.Web.Controllers
{
    public class CihazController : Controller
    {
        private readonly ICihazService _cihazService;

        public CihazController(ICihazService cihazService)
        {
            _cihazService = cihazService;
        }
        public IActionResult Index()
        {
            var liste = _cihazService.GetAll();
            return View(liste);
        }
        [HttpGet]
        public IActionResult YeniCihaz()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniCihaz(Cihaz a)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    a.CihazKayitTarihi = System.DateTime.Now;
                    a = _cihazService.Insert(a);

                }
                catch (System.Exception)
                {

                    throw;
                }
            }

            return RedirectToAction("Index");
        }
        public IActionResult YeniSil(int id)
        {
            var deletemodel = _cihazService.Get(x => x.Id == id);
            //_arizaService.Update(a);
            if (deletemodel != null)
            {
                _cihazService.Delete(deletemodel);
            }
            //var sil = _arizaService.Find(id);

            return RedirectToAction("Index");
        }
      
        public IActionResult CihazGetir(int id)
        {
            var getirmodel = _cihazService.Get(x => x.Id == id);

            //var list = new List<SelectListItem> {
            //    new SelectListItem { Text = "Aktif", Value = "True" },
            //    new SelectListItem { Text = "Pasif", Value = "False" }
            //};
            //TempData["aktifpasif"] = list;
            return View(getirmodel);
        }
        [HttpPost]
        public IActionResult CihazGuncelle(Cihaz model)
        {
            var guncellemodel = _cihazService.Get(x => x.Id == model.Id);
            if (guncellemodel != null)
            {
                guncellemodel.CihazAd = model.CihazAd;
                guncellemodel.CihazTip = model.CihazTip;
                guncellemodel.CihazKayitTarihi = model.CihazKayitTarihi;
                
                _cihazService.Update(guncellemodel);
            }

            return RedirectToAction("Index");
        }
    }
}