using Microsoft.AspNetCore.Mvc;

namespace LearnProject.MvcWebUI.Controllers
{
    public class ComponentController : Controller
    {
        // GET: Components
        public ActionResult Index()
        {
            return View();
        }

        // GET: Components/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Components/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Components/Create
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

        // GET: Components/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Components/Edit/5
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

        // GET: Components/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Components/Delete/5
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

        public ActionResult Alerts()
        {
            return View();
        }

        public ActionResult Accordion()
        {
            return View();
        }

        public ActionResult Badges()
        {
            return View();
        }

        public ActionResult Breadcrumbs()
        {
            return View();
        }

        public ActionResult Buttons()
        {
            return View();
        }

        public ActionResult Cards()
        {
            return View();
        }

        public ActionResult Carousel()
        {
            return View();
        }

        public ActionResult ListGroup()
        {
            return View();
        }

        public ActionResult Modal()
        {
            return View();
        }

        public ActionResult Tabs()
        {
            return View();
        }

        public ActionResult Pagination()
        {
            return View();
        }

        public ActionResult Progress()
        {
            return View();
        }

        public ActionResult Spinners()
        {
            return View();
        }

        public ActionResult Tooltips()
        {
            return View();
        }

    }
}
