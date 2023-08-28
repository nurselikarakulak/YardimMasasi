using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YardimMasasi.Sunum.Models.BirimViewModels;

namespace YardimMasasi.Sunum.Controllers
{
    public class BirimController : Controller
    {
        // GET: BirimController
        public ActionResult Index()
        {
            var liste  = new List<BirimListItemViewModel>();

            liste.Add(new BirimListItemViewModel
            {
                Id= 1,
                Adi = " Teknik Destek Birimi"
            });

            liste.Add(new BirimListItemViewModel
            {
                Id = 2,
                Adi = " İletişim ve Halkla İlişkiler Birimi"
            });

            liste.Add(new BirimListItemViewModel
            {
                Id = 3,
                Adi = " Denetim Birimi"
            });

            return View(liste);
        }

        // GET: BirimController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BirimController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BirimController/Create
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

        // GET: BirimController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BirimController/Edit/5
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

        // GET: BirimController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BirimController/Delete/5
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
