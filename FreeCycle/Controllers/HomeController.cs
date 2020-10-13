using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FreeCycle.Models;

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
        

        [HttpPost]
        public async Task<IActionResult> Validacion(String Email, String Password)
        {
            var Usuario = _context.Usuario.FirstOrDefault(user => user.Email == Email);
            if(Usuario != null)
            {
                if (Usuario.Password == Password)
                {
                    return RedirectToAction("HomePage", "Home");
                }
                else
                {
                    //Ver cómo se imprime un mensaje de CONTRASEÑA INCORRECTA
                    return RedirectToAction("Index","Home");
                }
               
            }
            else
            {
                var Empresa = _context.Empresa.FirstOrDefault(empresa => empresa.Email == Email);
                if (Empresa != null)
                {
                    if (Empresa.Password == Password)
                    {
                        return RedirectToAction("HomePage", "Home");
                    }
                    else
                    {
                        //Ver cómo se imprime un mensaje de CONTRASEÑA INCORRECTA
                        return RedirectToAction("Index", "Home");
                    }

                }
            }
            //Ver cómo se imprime un mensaje de CUENTA INEXISTENTE
            return RedirectToAction("Index", "Home");
            
        }

      

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult HomePage()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
