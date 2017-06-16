using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppBioBackEnd.Web.API.Controllers
{
    public class AulasController : Controller
    {
        // GET: Aulas
        public ActionResult Index()
        {
            return View();
        }

        // GET: Aulas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Aulas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aulas/Create
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

        // GET: Aulas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Aulas/Edit/5
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

        // GET: Aulas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Aulas/Delete/5
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
