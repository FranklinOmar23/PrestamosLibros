using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PrestamosLibros.Web.Controllers
{
    public class AlquileresController : Controller
    {
        // GET: AlquileresController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AlquileresController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AlquileresController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AlquileresController/Create
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

        // GET: AlquileresController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AlquileresController/Edit/5
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

        // GET: AlquileresController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AlquileresController/Delete/5
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
