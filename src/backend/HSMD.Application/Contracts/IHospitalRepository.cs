using HSMD.Domain.Models;

namespace HSMD.Application.Contracts
{
    public interface IHospitalRepository
    {
        Task<IEnumerable<Hospital>> GetAllHospitalsAsync(bool trackChanges);
        Task<Hospital> GetHospitalByIdAsync(int id, bool trackChanges);
        Task<Hospital> GetHospitalByNameAsync(string name, bool trackChanges);
        void CreateHospital(Hospital hospital);
        void DeleteHospital(Hospital hospital);
    }
}
