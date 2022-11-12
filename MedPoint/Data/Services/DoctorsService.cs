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

        public void Add(Doctor model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Doctor>> GetAll()
        {
            var result = await _context.Doctors.ToListAsync();
            return result;
        }

        public Doctor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Doctor model)
        {
            throw new NotImplementedException();
        }
    }
}
