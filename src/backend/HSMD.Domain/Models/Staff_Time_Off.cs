using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Domain.Models
{
    public class Staff_Time_Off
    {
        public int StaffId { get; set; }
        public int WardId { get; set; }
        public DateTime Date_From { get; set; }
        public DateTime Date_To { get; set;}
    }
}
