using MedPoint.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using MedPoint.Data;

namespace MedPoint.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDBContext _context;

        public HomeController(ILogger<HomeController> logger, AppDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Doctors.ToList();
            return View(data);
        }

        public IActionResult Privacy()
        {         
            return View();
        }
        public IActionResult Visit()
        {
            return View("~/Views/Visits/Index.aspx");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}