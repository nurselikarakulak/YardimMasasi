using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YardimMasasi.IsKatmani.Soyut;
using YardimMasasi.Nesneler.HaberNesneler.Dto;
using YardimMasasi.Sunum.Models.HaberViewModels;

namespace YardimMasasi.Sunum.Controllers
{
    public class HaberController : Controller
    {
        private readonly IHaberService _service;

        public HaberController(IHaberService service)
        {
            _service = service;
        }

        // GET: HaberController
        public ActionResult Index()
        {
            var liste = _service.GetirHaberListe();

            var vmList = liste.Select(a => new HaberListItemViewModel
            {
                Id = a.Id,
                Baslik = a.Baslik,
                Icerik = a.Icerik,
                YayinTarihi = a.YayinTarihi
            });

            return View(vmList);
        }

        // GET: HaberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HaberController/Create
        public ActionResult Create()
        {
            return View(new HaberCreateViewModel());
        }

        // POST: HaberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] HaberListItemViewModel model)
        {
            try
            {
                _service.HaberEkle(new Nesneler.HaberNesneler.Dto.HaberEkleDto
                {
                    Baslik = model.Baslik,
                    Icerik = model.Icerik,
                    YayinTarihi = model.YayinTarihi
                });

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HaberController/Edit/5
        public ActionResult Edit(int id)
        {
            var h = _service.HaberGetir(id);


            return View(new HaberUpdateViewModel()
            {
                Id = h.Id,
                Baslik = h.Baslik,
                Icerik = h.Icerik,
                YayinTarihi = h.YayinTarihi
            });
        }

        // POST: HaberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [FromForm] HaberUpdateViewModel model)
        {
            try
            {
                model.Id = id;

                _service.HaberGuncelle(id, new Nesneler.HaberNesneler.Dto.HaberGuncelleDto
                {
                    Baslik = model.Baslik,
                    Icerik = model.Icerik,
                    YayinTarihi = model.YayinTarihi
                });

                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        // GET: HaberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HaberController/Delete/5
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
