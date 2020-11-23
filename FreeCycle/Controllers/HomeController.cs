using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FreeCycle.Models;
using FreeCycle.ViewModels;

namespace FreeCycle.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DatabaseContext _context;

        public HomeController(DatabaseContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        //Flag 0 para correo incorrecto 
        //Flag 1 para contraseña incorrecta
        //Flag 2 para inicio de sesión exitoso
        
        [HttpPost]
        public async Task<IActionResult> Validacion([Bind("Email,Password")] Validacion validacion)
        {
                int flag = 0;
                var Usuario = _context.Usuario.FirstOrDefault(user => user.Email == validacion.Email);
                if (Usuario != null)
                {
                    if (Usuario.Password == validacion.Password)
                    {
                        
                        return RedirectToAction("HomePage", new { flag = 2,UsuarioId=Usuario.Id});
                    }
                    flag = 1;
                 

                }
                else
                {
                    var Empresa = _context.Empresa.FirstOrDefault(empresa => empresa.Email == validacion.Email);
                    if (Empresa != null)
                    {
                        if (Empresa.Password == validacion.Password)
                        {
                            return RedirectToAction("HomePage", new { flag = 2 });
                        }
                        flag = 1;
                    }
                    
                }
                ViewBag.flag = flag;
                
                return View("InicioSesion", validacion);
        }

        public IActionResult Index()
        {
            return View();
        }


        //Le llega la flag para mostrar el mensaje de registro exitoso
        //Este sería el flag 3
        public IActionResult GoToIndex(int flag)
        {
            ViewBag.flag = flag;
            return View("InicioSesion");
        }

        public IActionResult InicioSesion()
        {
            return View();
        }

        

        public IActionResult HomePage(int flag , int UsuarioId, string Email)
        {
            if(UsuarioId != 0 )
            {
                ViewBag.flag = flag;
                ViewBag.UsuarioId = UsuarioId;
                ViewBag.Email = Email;
                return View();
            }
            ViewBag.flag = 8;
            return View("InicioSesion");
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
