using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppBioBackEnd.Web.API.Controllers
{
    public class UnidadesController : Controller
    {
        // GET: Unidades
        public ActionResult Index()
        {
            return View();
        }

        // GET: Unidades/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Unidades/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Unidades/Create
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

        // GET: Unidades/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Unidades/Edit/5
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

        // GET: Unidades/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Unidades/Delete/5
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
