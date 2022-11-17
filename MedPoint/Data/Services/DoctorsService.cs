using MedPoint.Models;
using Microsoft.EntityFrameworkCore;

namespace MedPoint.Data.Services
{
    public class DoctorsService : IDoctorsService
    {
        private readonly AppDBContext _context;
        public DoctorsService(AppDBContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Doctor model)
        {
            await _context.Doctors.AddAsync(model);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Doctors.FindAsync(id);
            _context.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Doctor>> GetAllAsync()
        {
            var result = await _context.Doctors.ToListAsync();
            return result;
        }

        public async Task<Doctor> GetByIdAsync(int id)
        {
            var result = await _context.Doctors.FindAsync(id);
            return result;
        }

        public async Task<Doctor> UpdateAsync(int it, Doctor model)
        {
            _context.Update(model);
            await _context.SaveChangesAsync();
            return model;
        }
    }
}
