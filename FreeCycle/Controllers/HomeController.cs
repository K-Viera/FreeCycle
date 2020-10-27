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


        [HttpPost]
        public async Task<IActionResult> Validacion([Bind("Email,Password")] Validacion validacion)
        {
                int flag = 0;
                var Usuario = _context.Usuario.FirstOrDefault(user => user.Email == validacion.Email);
                if (Usuario != null)
                {
                    if (Usuario.Password == validacion.Password)
                    {
                        
                        return RedirectToAction("HomePage", new { flag = 1,UsuarioId=Usuario.Id});
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
                            return RedirectToAction("HomePage", new { flag = 1 });
                        }
                        flag = 1;
                    }
                    
                }
                ViewBag.flag = flag;
                //Ver cómo se imprime un mensaje de CUENTA INEXISTENTE
                return View("Index", validacion);
        }

        public IActionResult GoToIndex()
        {
            int flag = 3;
            ViewBag.flag = flag;
            return View("Index");
        }

        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult HomePage(int flag,int UsuarioId)
        {
            ViewBag.flag = flag;
            ViewBag.UsuarioId = UsuarioId;
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
