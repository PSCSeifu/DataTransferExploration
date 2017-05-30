using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESetup.Types.Import.dto
{
    public class dtoGrade
    {
        public string Description { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int PayrollId { get; set; }
        public bool InUse { get; set; }
        public int OrganisationId { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedUser { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
