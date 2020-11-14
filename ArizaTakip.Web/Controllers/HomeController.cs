using ArizaTakip.Business.Interfaces;
using ArizaTakip.DataAccess.Concrete.EntitiyFrameworkCore.Contexts;
using ArizaTakip.Entites.Concrete;
using ArizaTakip.Entities.Concrete;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Owin.Security;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace ArizaTakip.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {

        private readonly IArizaService _arizaService;
        private readonly ICihazService _cihazService;
        private readonly IIletisimService _iletisimService;


        private readonly ArizaTakipContext _contex;
        public HomeController(IArizaService arizaService, ICihazService cihazService, IIletisimService iletisimService, ArizaTakipContext context)
        {
            _arizaService = arizaService;
            _cihazService = cihazService;
            _iletisimService = iletisimService;
            _contex = context;
        }

        public IActionResult Index()
        {
            var liste = _arizaService.GetAll();

            var cihazlar = _cihazService.GetAll();
            TempData["cihazlar"] = cihazlar;
            return View(liste);
        }

        [HttpGet]
        public IActionResult YeniAriza()
        {
            var cihazlar = _cihazService.GetAll();
            var cihazdropdown = cihazlar.Select(s => new SelectListItem { Text = s.CihazAd, Value = s.Id.ToString() }).ToList();
            TempData["cihazDropDown"] = cihazdropdown;
            return View();
        }
        [HttpPost]
        public IActionResult YeniAriza(Ariza a)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    a.KayitTarihi = System.DateTime.Now;
                    a = _arizaService.Insert(a);

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
            var deletemodel = _arizaService.Get(x => x.Id == id);
            //_arizaService.Update(a);
            if (deletemodel != null)
            {
                _arizaService.Delete(deletemodel);
            }
            //var sil = _arizaService.Find(id);

            return RedirectToAction("Index");
        }

        public IActionResult ArizaGetir(int id)
        {
            var cihazlar = _cihazService.GetAll();
            var cihazdropdown = cihazlar.Select(s => new SelectListItem { Text = s.CihazAd, Value = s.Id.ToString() }).ToList();
            TempData["cihazDropDown"] = cihazdropdown;
            if (id > 0)
            {
                var getirmodel = _arizaService.Get(x => x.Id == id);
                return View(getirmodel);
            }

            //var list = new List<SelectListItem> {
            //    new SelectListItem { Text = "Aktif", Value = "True" },
            //    new SelectListItem { Text = "Pasif", Value = "False" }
            //};
            //TempData["aktifpasif"] = list;
            return View();
        }

        [HttpPost]
        public IActionResult ArizaGuncelle(Ariza model)
        {
            var cihazlar = _cihazService.GetAll();
            var guncellemodel = _arizaService.Get(x => x.Id == model.Id);

            if (guncellemodel != null)
            {
                guncellemodel.ArizaAciklama = model.ArizaAciklama;
                guncellemodel.ArizaOlusturulmaTarih = model.ArizaOlusturulmaTarih;
                guncellemodel.ArizaTanim = model.ArizaTanim;
                guncellemodel.Durum = model.Durum;
                guncellemodel.KayitTarihi = model.KayitTarihi;

                _arizaService.Update(guncellemodel);

            }

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult IletiIslemleri()
        {
            var yorumlar = _iletisimService.GetAll();

            return View();
        }
        [HttpPost]
        public IActionResult IletiIslemleri(Iletisim a)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    a.Tarih = System.DateTime.Now;
                    a = _iletisimService.Insert(a);

                }
                catch (System.Exception)
                {

                    throw;
                }
            }

            return RedirectToAction();
        }
        public IActionResult IletimIslemleri(int id)
        {
            var cihazlar = _iletisimService.GetAll();


            if (id > 0)
            {
                var getirmodel = _iletisimService.Get(x => x.Id == id);
                return PartialView(getirmodel);
            }

            return View(cihazlar);
        }


        //[HttpPost]
        //public IActionResult Iletisim(/*string KullaniciAd, string Email, string Ileti, int id*/)
        //{
        //    {
        //        //if (KullaniciAd != null && Email != null && Email != null)
        //        //{
        //        //    int uyeId = System.Convert.ToInt32(id);
        //        //    var yorum = _iletisimService;
        //        //    yorum.Insert(new Iletisim()
        //        //    {
        //        //        //KullaniciAd = yorum,
        //        //        KullaniciAd = KullaniciAd,
        //        //        KullaniciMail = Email,
        //        //        Ileti = Ileti,
        //        //        Tarih = System.DateTime.Now
        //        //    });
        //        //    //_arizaService.Update(id);
        //        //}

        //    }
        //    return View();
        //}
    }

    //public IActionResult Iletisim(int Id)
    //{
    //    List<Personel> yorumliste = _iletisimService.Get(Id);
    //    return View(yorumliste);
    //}
    //[HttpPost]
    //public PartialViewResult Yorum(Iletisim a)
    //{
    //    a = _iletisimService.Insert(a);
    //    return PartialView();

    //}




    //    public IActionResult Iletisim(Iletisim a)
    //     {
    //         if (ModelState.IsValid)
    //         {
    //             try
    //             {
    //                 a.KayitTarihi = System.DateTime.Now;
    //                 a = _arizaService.Insert(a);

    //            }
    //            catch (System.Exception)
    //            {

    //                throw;
    //            }

    //}
    //        public IActionResult Durum(int id)
    //        {
    //            var durummodel = _arizaService.Get(x => x.Durum == false);
    //            _arizaService.Update(a);
    //            if (durummodel != null)
    //            {

    //            }

    //            return RedirectToAction("Index");
    //        }
    //        public IActionResult Chat()
    //        {
    //            return View();
}

