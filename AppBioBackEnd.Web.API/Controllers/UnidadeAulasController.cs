using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppBioBackEnd.Web.API.Controllers
{
    public class UnidadeAulasController : Controller
    {
        // GET: UnidadeAulas
        public ActionResult Index()
        {
            return View();
        }

        // GET: UnidadeAulas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UnidadeAulas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UnidadeAulas/Create
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

        // GET: UnidadeAulas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UnidadeAulas/Edit/5
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

        // GET: UnidadeAulas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UnidadeAulas/Delete/5
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
