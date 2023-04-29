using HSMD.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Domain.Models
{
    public class Staff_Qualifications:AuditableBaseEntity
    {
        //[ForeignKey(nameof(Staff))]
        public int StaffId { get; set; }
        public int Qualification_Code { get; set; }
        public DateTime Date_Obtained { get; set; }

        //public Staff Staff { get; set; }
    }
}
