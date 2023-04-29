using HSMD.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Application.Contracts
{
    public interface IStaff_Qualifications_Repository
    {
        Task<IEnumerable<IStaff_Qualifications_Repository>> GetAllStaffQualificationsAsync(bool trackChanges);
        Task<IStaff_Qualifications_Repository> GetStaffQualificationByIdAsync(int staffId, bool trackChanges);
        Task<IStaff_Qualifications_Repository> GetStaffQualificationByNameAsync(string firstName, string lastName, bool trackChanges);
        void CreateStaff(IStaff_Qualifications_Repository staffQualification);
        void DeleteStaff(IStaff_Qualifications_Repository staffQualification);
    }
}
