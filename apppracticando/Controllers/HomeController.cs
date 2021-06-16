using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using apppracticando.Models;

namespace apppracticando.Controllers
{
    public class HomeController : Controller
    {
        private readonly apppracticandoContext _context;
        private readonly ILogger<HomeController> _logger;

          public HomeController(apppracticandoContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var fails = _context.Fail.Where(x => x.Fecha.AddDays(5) >= DateTime.Now).ToList();
            return View(fails);
        }

        public IActionResult Ingreso()
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
