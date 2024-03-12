using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PostoInformatica_ERP.Controllers
{
    public class OBRASController : Controller
    {
        // GET: OBRASController
        public ActionResult Index()
        {
            return View();
        }

        // GET: OBRASController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OBRASController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OBRASController/Create
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

        // GET: OBRASController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OBRASController/Edit/5
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

        // GET: OBRASController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OBRASController/Delete/5
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
