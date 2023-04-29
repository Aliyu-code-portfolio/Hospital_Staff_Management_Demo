using HSMD.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Application.Contracts
{
    public interface IStaff_Time_Off_Repository
    {
        Task<IEnumerable<Staff_Time_Off>> GetAllStaffTimeOffsAsync(bool trackChanges);
        Task<Staff_Time_Off> GetStaffTimeOffByIdAsync(int staffId, bool trackChanges);
        Task<Staff_Time_Off> GetStaffTimeOffByNameAsync(string firstName, string lastName, bool trackChanges);
        void CreateStaff(Staff_Time_Off staffTimeOff);
        void DeleteStaff(Staff_Time_Off staffTimeOff);
    }
}
