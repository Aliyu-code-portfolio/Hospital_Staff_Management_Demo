using HSMD.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Domain.Models
{
    public class Staff_Ward_Assignments:AuditableBaseEntity
    {
        [ForeignKey(nameof(Staff))]
        public int StaffId { get; set; }
        [ForeignKey(nameof(Wards))]
        public int WardId { get; set; }
        public DateTime Date_From { get; set; }
        public DateTime Date_To { get; set;}

        public Staff Staff { get; set; }
    }
}
