using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission3Apsio2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission3Apsio2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyDbContext _context;
        private readonly MyDbContext _context2;

        public HomeController(ILogger<HomeController> logger, MyDbContext context, MyDbContext context2)
        {
            _logger = logger;
            _context = context;
            _context2 = context2;

        }

        public IActionResult  Index()
        {
            IEnumerable<Medicament> medicaments = _context.Medicaments;  
            return View(medicaments);
            
        }

        public IActionResult Privacy()
        {
            IEnumerable<Sante> santes = _context2.Santes;
            return View(santes);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
