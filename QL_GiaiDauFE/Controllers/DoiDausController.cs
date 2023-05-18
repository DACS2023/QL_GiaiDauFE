using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QL_GiaiDauFE.Controllers
{
    public class DoiDausController : Controller
    {
        // GET: DoiDaus
        public ActionResult Index()
        {
            return View();
        }

        // GET: DoiDaus/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DoiDaus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DoiDaus/Create
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

        // GET: DoiDaus/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DoiDaus/Edit/5
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

        // GET: DoiDaus/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DoiDaus/Delete/5
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
