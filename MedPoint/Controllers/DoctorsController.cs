using MedPoint.Data;
using MedPoint.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace MedPoint.Controllers
{
    public class DoctorsController : Controller
    {

        private readonly IDoctorsService _service;
        public DoctorsController(IDoctorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
