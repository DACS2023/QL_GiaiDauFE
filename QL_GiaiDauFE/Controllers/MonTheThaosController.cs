using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QL_GiaiDauFE.Controllers
{
    public class MonTheThaosController : Controller
    {
        // GET: MonTheThaos
        public ActionResult Index()
        {
            return View();
        }

        // GET: MonTheThaos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MonTheThaos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MonTheThaos/Create
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

        // GET: MonTheThaos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MonTheThaos/Edit/5
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

        // GET: MonTheThaos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MonTheThaos/Delete/5
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
