using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QL_GiaiDauFE.Controllers
{
    public class CT_TranDauController : Controller
    {
        // GET: CT_TranDau
        public ActionResult Index()
        {
            return View();
        }

        // GET: CT_TranDau/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CT_TranDau/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CT_TranDau/Create
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

        // GET: CT_TranDau/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CT_TranDau/Edit/5
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

        // GET: CT_TranDau/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CT_TranDau/Delete/5
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
