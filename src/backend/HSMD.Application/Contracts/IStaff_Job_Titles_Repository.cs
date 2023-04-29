using HSMD.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Application.Contracts
{
    public interface IStaff_Job_Titles_Repository
    {
        Task<IEnumerable<Staff_Job_Titles>> GetAllStaffJobTitlesAsync(bool trackChanges);
        Task<Staff_Job_Titles> GetStaffJobTitleByIdAsync(int staffId, bool trackChanges);
        Task<Staff_Job_Titles> GetStaffJobTitleByNameAsync(string firstName, string lastName, bool trackChanges);
        void CreateStaffJobTitle(Staff_Job_Titles staffJobTitle);
        void DeleteStaffJobTitle(Staff_Job_Titles staffJobTitle);
    }
}
