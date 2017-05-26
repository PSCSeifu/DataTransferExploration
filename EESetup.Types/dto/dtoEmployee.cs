using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESetup.Types.dto
{
    public class dtoEmployee
    {
        public string EmployeeNo { get; set; }
        public string Surname { get; set; }
        public string Initials { get; set; }
        public int Title { get; set; }
        public int DepartmentId { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
