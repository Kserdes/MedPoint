using MedPoint.Models;

namespace MedPoint.Data.Services
{
    public interface IVisitsService
    {
        Task<IEnumerable<Visit>> GetAllAsync();
        Task<Visit> GetByIdAsync(int id);
        Task AddAsync(Visit model);
        Task<Visit> UpdateAsync(int it, Visit visit);
        Task DeleteAsync(int id);
        Task<Visit> GetDoctorsListAsync();
    }
}
