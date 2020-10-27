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
    public class UsuariosController : Controller
    {
        private readonly DatabaseContext _context;
        public IActionResult Create()
        {
            return View();
        }
        public UsuariosController(DatabaseContext context)
        {
            _context = context;
        }

        //Flag 0 para email ya registrado
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Password,PhoneNumber,Email")] Usuario usuario)
        {
            int flag;
            String temp = usuario.Email;
            var Usuario = _context.Usuario.FirstOrDefault(user => user.Email == temp);
            if (Usuario == null)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(usuario);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("GoToIndex", "Home", new { flag = 3 });
                }
                
            }
            flag = 0;
            ViewBag.flag = flag;
            return View(usuario);
        }

       
       
    }
}
