using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YardimMasasi.Sunum.Models.AnaKonu;

namespace YardimMasasi.Sunum.Controllers
{
    public class AnaKonuController : Controller
    {
        // GET: AnaKonularController
        public ActionResult Index()
        {
            var liste = new List<AnaKonuListItemViewModel>();

            liste.Add(new AnaKonuListItemViewModel
            {
                Id = 1,
                Adi= "Mail Sorunları "

            });
            liste.Add(new AnaKonuListItemViewModel
            {
                Id = 2,
                Adi= "İletişim Sorunları "

            });
            liste.Add(new AnaKonuListItemViewModel
            {
                Id = 3,
                Adi= "Oturma Sorunları "

            });
            liste.Add(new AnaKonuListItemViewModel
            {
                Id = 4,
                Adi= "Ekipman Sorunları "

            });
            liste.Add(new AnaKonuListItemViewModel
            {
                Id = 5,
                Adi= "İnşaat Sorunları "

            });




            return View(liste);
        }

        // GET: AnaKonularController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AnaKonularController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnaKonularController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: AnaKonularController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AnaKonularController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: AnaKonularController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AnaKonularController/Delete/5
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
