using MedPoint.Models;

namespace MedPoint.Data.Services
{
    public interface IDoctorsService
    {
        Task<IEnumerable<Doctor>> GetAllAsync();
        Task<Doctor> GetByIdAsync(int id);
        Task AddAsync(Doctor model);
        Task<Doctor> UpdateAsync(int it, Doctor model);
        void Delete(int id);
    }
}
