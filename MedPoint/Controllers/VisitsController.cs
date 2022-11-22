using MedPoint.Data.Services;
using MedPoint.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MedPoint.Controllers
{
    public class VisitsController : Controller
    {
        private readonly IVisitsService _service;
        public VisitsController(IVisitsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index(IdentityAccount account)
        {
            var model = await _service.GetDoctorsListAsync();
            model.StartDate = DateTime.Today;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Created([Bind("PatientName,DoctorName,StartDate")] Visit visit)
        {
            var doctorList = await _service.GetDoctorsListAsync();
            if (!ModelState.IsValid)
            {
                return View("Index", doctorList);

            }
            await _service.AddAsync(visit);
            return View("Created");
        }
    }
}
