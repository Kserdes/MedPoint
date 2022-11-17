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
            var data = await _service.GetAllAsync();
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
            await _service.AddAsync(doctor);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int id)
        {
            var doctorEdit = await _service.GetByIdAsync(id);
            if (doctorEdit == null)
            {
                return View("Nie znaleziono");
            }
            return View(doctorEdit);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Doctor doctor)
        {
            if (!ModelState.IsValid)
            {
                return View(doctor);


            }
            await _service.UpdateAsync(id, doctor);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            var doctorEdit = await _service.GetByIdAsync(id);
            if (doctorEdit == null) return View("Nie znaleziono");
            return View(doctorEdit);
        }
        [HttpPost, ActionName("Delete")] 
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var doctor = await _service.GetByIdAsync(id);
            if (doctor == null) return View("Nie znaleziono");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
