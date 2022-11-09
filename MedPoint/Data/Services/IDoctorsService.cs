using MedPoint.Models;

namespace MedPoint.Data.Services
{
    public interface IDoctorsService
    {
        IEnumerable<Doctor> GetAll();
        Doctor GetById(int id);
        void Add(Doctor model);
        void Update(Doctor model);
        void Delete(int id);
    }
}
