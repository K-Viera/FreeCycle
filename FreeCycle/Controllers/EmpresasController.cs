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
    public class EmpresasController : Controller
    {
        private readonly DatabaseContext _context;

        public EmpresasController(DatabaseContext context)
        {
            _context = context;
        }

     
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CompanyName,Password,PhoneNumber,Email,NIT")] Empresa empresa)
        {
            int flag;
            String temp = empresa.Email;
            var Empresa = _context.Empresa.FirstOrDefault(empresa => empresa.Email == temp);
            if(Empresa == null)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(empresa);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("GoToIndex", "Home", new { flag = 3 });
                }
            }
            flag = 0;
            ViewBag.flag = flag;
            return View(empresa);
        }

       
    }
}
