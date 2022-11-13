using MedPoint.Data;
using MedPoint.Data.Services;
using MedPoint.Models;
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
        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL,FullName,Specialization")]Doctor doctor)
        {
            if (!ModelState.IsValid)
            {
                return View(doctor);
                

            }
            _service.Add(doctor);
            return RedirectToAction(nameof(Index));
        }
    }
}
