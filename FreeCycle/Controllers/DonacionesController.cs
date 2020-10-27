using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeCycle.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreeCycle.Controllers
{
    public class DonacionesController : Controller
    {
        private readonly DatabaseContext _context;

        public DonacionesController(DatabaseContext context)
        {
            _context = context;
        }
        // GET: DonacionesController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SolicitudDonacion(int UsuarioId)
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearSolicitud([Bind("UsuarioId,adress,objeto")]SolicitudDonacion solicitud)
        {
            if (ModelState.IsValid)
            {
                _context.Add(solicitud);
                await _context.SaveChangesAsync();
                //hacer aviso de registro de solicitud exitoso
                return RedirectToAction("HomePage", "Home", new { flag = 3, UsuarioId=solicitud.UsuarioId });
            }
            return View("SolicitudDonacion", solicitud);
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
