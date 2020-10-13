using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreeCycle.Controllers
{
    public class DonacionesController : Controller
    {
        // GET: DonacionesController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SolicitudDonacion()
        {
            return View();
        }

        // GET: DonacionesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DonacionesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DonacionesController/Create
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

        // GET: DonacionesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DonacionesController/Edit/5
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

        // GET: DonacionesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DonacionesController/Delete/5
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
