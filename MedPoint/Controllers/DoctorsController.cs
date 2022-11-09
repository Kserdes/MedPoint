using MedPoint.Data;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace MedPoint.Controllers
{
    public class DoctorsController : Controller
    {

        private readonly AppDBContext _context;
        public DoctorsController(AppDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Doctors.ToList();
            return View(data);
        }
    }
}
