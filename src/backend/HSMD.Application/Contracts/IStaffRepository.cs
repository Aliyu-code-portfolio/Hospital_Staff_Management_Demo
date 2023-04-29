using HSMD.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Application.Contracts
{
    public interface IStaffRepository
    {
        Task<IEnumerable<Staff>> GetAllStaffsAsync(bool trackChanges);
        Task<Staff> GetStaffByIdAsync(int id, bool trackChanges);
        Task<Staff> GetStaffByNameAsync(string firstName, string lastName, bool trackChanges);
        void CreateStaff(Staff staff);
        void DeleteStaff(Staff staff);
    }
}
