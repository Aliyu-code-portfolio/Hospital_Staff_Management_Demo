using HSMD.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Application.Contracts
{
    public interface IStaff_Ward_Assignment_Repository
    {
        Task<IEnumerable<Staff_Ward_Assignments>> GetAllStaffWardAssignmentsAsync(bool trackChanges);
        Task<Staff_Ward_Assignments> GetStaffWardAssignmentByIdAsync(int staffId, bool trackChanges);
        Task<Staff_Ward_Assignments> GetStaffWardAssignmentByNameAsync(string firstName, string lastName, bool trackChanges);
        void CreateStaff(Staff_Ward_Assignments staffWardAssignment);
        void DeleteStaff(Staff_Ward_Assignments staffWardAssignment);
    }
}
