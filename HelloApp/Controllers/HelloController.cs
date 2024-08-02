using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelloApp.Controllers
{
    public class HelloController : Controller
    {
        // GET: HelloController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HelloController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HelloController/SayHello/5
        public ActionResult SayHello()
        {
            return View();
        }
        // GET: HelloController/YellHello/5
        public ActionResult YellHello()
        {
            return View();
        }

        // GET: HelloController/Create

        public ActionResult Create()
        {
            return View();
        }

        // POST: HelloController/Create
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

        // GET: HelloController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HelloController/Edit/5
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

        // GET: HelloController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HelloController/Delete/5
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
