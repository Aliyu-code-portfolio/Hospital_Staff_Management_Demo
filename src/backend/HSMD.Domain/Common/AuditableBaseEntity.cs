using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Domain.Common
{
    public abstract class AuditableBaseEntity
    {
        public int Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }= DateTime.Now;
        public string? ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }
        
    }
}
