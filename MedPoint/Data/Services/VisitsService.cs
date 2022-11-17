using MedPoint.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace MedPoint.Data.Services
{
    public class VisitsService : IVisitsService
    {
        private readonly AppDBContext _context;
        public VisitsService(AppDBContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Visit model)
        {
            model.isBusy = true;
            model.EndDate = DateTime.Now;
            await _context.Visits.AddAsync(model);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Visits.FindAsync(id);
            _context.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Visit>> GetAllAsync()
        {
            var result = await _context.Visits.ToListAsync();
            return result;
        }

        public async Task<Visit> GetByIdAsync(int id)
        {
            var result = await _context.Visits.FindAsync(id);
            return result;
        }

        public async Task<Visit> GetDoctorsListAsync()
        {
            var doctorList = await _context.Doctors.ToListAsync();
            var model = new Visit();
            model.Doctors = new List<SelectListItem>();
            foreach (var doctor in doctorList)
            {                
                model.Doctors.Add(new SelectListItem { Text = doctor.FullName, Value = doctor.FullName });
            }
            return model;
        }

        public async Task<Visit> UpdateAsync(int id, Visit model)
        {
            _context.Update(model);
            await _context.SaveChangesAsync();
            return model;
        }

    }
}
