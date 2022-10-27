using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PrestamosLibros.Web.Controllers
{
    public class LectoresController : Controller
    {
        // GET: LectoresController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LectoresController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LectoresController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LectoresController/Create
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

        // GET: LectoresController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LectoresController/Edit/5
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

        // GET: LectoresController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LectoresController/Delete/5
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
