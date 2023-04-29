using HSMD.Application.Contracts;

namespace HSMD.Application.CommonContracts
{
    public interface IRepositoryManager
    {
        IHospitalRepository hospital {  get; }
        IStaffRepository staff { get; }
        IStaff_Job_Titles_Repository staff_job_titles { get; }
        IStaff_Qualifications_Repository staff_qualifications { get; }
        IStaff_Ward_Assignment_Repository staff_Ward_Assignment { get; }
        IStaff_Time_Off_Repository staff_time_off { get; }
        Task SaveChanges();
    }
}
