using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESetup.Types.dto
{
    public class dtoMstr
    {
        public string EmployeeNo { get; set; }
        public string Surname { get; set; }
        public string Initials { get; set; }
        public int Title { get; set; }
        public int DepartmentNo { get; set; }
        public string DepartmentName { get; set; }
        public DateTime BirthDate { get; set; }
        public string SalaryHistory { get; set; }
        public bool IsUkWorker { get; set; }

        public dtoMstr(string data)
        {
            List<string> list = data.Split(',').ToList();
            this.BirthDate = Convert.ToDateTime(list[0]);
            this.DepartmentNo = Convert.ToInt16(list[1]);
            this.DepartmentName = list[2];
            this.EmployeeNo = list[3];
            this.Initials = list[4];
            this.Surname = list[5];
            this.Title = Convert.ToInt16(list[6]);
        }
    }
}
