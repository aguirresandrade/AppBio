using System.Web.Mvc;

namespace AppBioBackEnd.Web.API.Controllers
{
    public class AlunosController : Controller
    {
        // GET: Alunos
        public ActionResult Index()
        {
            return View();
        }

        // GET: Alunos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Alunos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alunos/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alunos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Alunos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alunos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Alunos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
