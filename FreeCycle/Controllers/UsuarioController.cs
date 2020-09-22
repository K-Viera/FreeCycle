using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeCycle.Models;
using Microsoft.AspNetCore.Mvc;

namespace FreeCycle.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly DatabaseContext _context;

        public UsuarioController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registro(String Nombre, String Password, long PhoneNumber)
        {
            Usuario user = new Usuario
            {
                Name = Nombre,
                Password = Password,
                PhoneNumber=PhoneNumber
            };
           _context.Usuario.Add(user);
            await _context.SaveChangesAsync();



            return View();
        }

        
    }
}
