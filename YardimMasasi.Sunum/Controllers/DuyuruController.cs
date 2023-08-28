using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using YardimMasasi.IsKatmani.Soyut;
using YardimMasasi.Sunum.Models.BirimViewModels;
using YardimMasasi.Sunum.Models.DuyuruViewModels;
using YardimMasasi.Sunum.Models.GorevMesajViewModels;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace YardimMasasi.Sunum.Controllers
{
    public class DuyuruController : Controller
    {
        private readonly IDuyuruService _service;

        public DuyuruController(IDuyuruService service)
        {
            _service = service;
        }

        // GET: DuyuruController
        public ActionResult Index()
        {
            var liste = _service.GetirDuyuruListe();

            var viewlist = liste.Select(a => new DuyuruListItemViewModel
            {
                Id = a.Id,
                Baslik = a.Baslik,
                Konu = a.Konu,
                BaslangicTarihi=a.BaslangicTarihi,
                BitisTarihi=a.BitisTarihi

            }).ToList();

            liste.Add(new Nesneler.DuyuruNesneler.Dto.DuyuruListeElemaniDto
            {
                Id = 0,
                Baslik = HttpContext.Session.GetString("Deneme1"),
                BaslangicTarihi = DateTime.Now,
                BitisTarihi = DateTime.Now,Konu = HttpContext.Session.GetString("Deneme1")
            });

            return View(liste);
        }

        // GET: DuyuruController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DuyuruController/Create
        public ActionResult Create()
        {
            return View(new DuyuruEkleViewModel());
        }

        // POST: DuyuruController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]

        public ActionResult Create([FromForm] DuyuruEkleViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            _service.DuyuruEkle(new Nesneler.DuyuruNesneler.Dto.DuyuruEkleDto
            {
                Konu = model.Konu,
                Baslik = model.Baslik,
                BaslangicTarihi = model.BaslangicTarihi,
                BitisTarihi = model.BitisTarihi
            });


            return Json(new { basarili=true });
        }
        // GET: DuyuruController/Edit/5
        public ActionResult Edit(int id)
        {

            var dyr = _service.GetirDuyuruGuncelle(id);

            return View(new DuyuruGuncelleViewModel
            {
                Id = dyr.Id,
                Konu = dyr.Konu,
                Baslik = dyr.Baslik,
                BaslangicTarihi = dyr.BaslangicTarihi,
                BitisTarihi = dyr.BitisTarihi
            });
        }

        // POST: DuyuruController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,[FromForm] DuyuruGuncelleViewModel dyr)
        {

            if (!ModelState.IsValid)
                return View(dyr);

            _service.DuyuruGuncelle( id, new  Nesneler.DuyuruNesneler.Dto.DuyuruDto
            {
                
                Konu = dyr.Konu,
                Baslik = dyr.Baslik,
                BaslangicTarihi = dyr.BaslangicTarihi,
                BitisTarihi = dyr.BitisTarihi
            });
            return RedirectToAction("Index");

        }

        // GET: DuyuruController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DuyuruController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
