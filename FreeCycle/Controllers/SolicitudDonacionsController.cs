using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FreeCycle.Models;

namespace FreeCycle.Controllers
{
    public class SolicitudDonacionsController : Controller
    {
        private readonly DatabaseContext _context;

        public SolicitudDonacionsController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: SolicitudDonacions
        public async Task<IActionResult> Index()
        {
            var databaseContext = _context.solicitudDonacion.Include(s => s.Usuario);
            return View(await databaseContext.ToListAsync());
        }

        // GET: SolicitudDonacions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitudDonacion = await _context.solicitudDonacion
                .Include(s => s.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solicitudDonacion == null)
            {
                return NotFound();
            }

            return View(solicitudDonacion);
        }

        // GET: SolicitudDonacions/Create
        public IActionResult Create()
        {
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "Id", "Email");
            return View();
        }

        // POST: SolicitudDonacions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,adress,objeto,UsuarioId")] SolicitudDonacion solicitudDonacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(solicitudDonacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "Id", "Email", solicitudDonacion.UsuarioId);
            return View(solicitudDonacion);
        }

        // GET: SolicitudDonacions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitudDonacion = await _context.solicitudDonacion.FindAsync(id);
            if (solicitudDonacion == null)
            {
                return NotFound();
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "Id", "Email", solicitudDonacion.UsuarioId);
            return View(solicitudDonacion);
        }

        // POST: SolicitudDonacions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,adress,objeto,UsuarioId")] SolicitudDonacion solicitudDonacion)
        {
            if (id != solicitudDonacion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(solicitudDonacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SolicitudDonacionExists(solicitudDonacion.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "Id", "Email", solicitudDonacion.UsuarioId);
            return View(solicitudDonacion);
        }

        // GET: SolicitudDonacions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitudDonacion = await _context.solicitudDonacion
                .Include(s => s.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solicitudDonacion == null)
            {
                return NotFound();
            }

            return View(solicitudDonacion);
        }

        // POST: SolicitudDonacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var solicitudDonacion = await _context.solicitudDonacion.FindAsync(id);
            _context.solicitudDonacion.Remove(solicitudDonacion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SolicitudDonacionExists(int id)
        {
            return _context.solicitudDonacion.Any(e => e.Id == id);
        }
    }
}
