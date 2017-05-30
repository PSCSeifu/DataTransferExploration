using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESetup.Types.Import.dto
{
    public class dtoDepartment
    {
        public string DepartmentNo { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int PeriodId { get; set; }
        public int CostCode1Id { get; set; }
        public int CostCode2Id { get; set; }
        public int CostCode3Id { get; set; }
        public int DepartmentId { get; set; }
        public int EmployeeId { get; set; }
        public string ShortName { get; set; }
        public int SiteId { get; set; }
        public string HierarchyCode { get; set; }
        public int CostCode4Id { get; set; }
        public int CostCode5Id { get; set; }
        public float CostCode1Per { get; set; }
        public float CostCode2Per { get; set; }
        public float CostCode3Per { get; set; }
        public float CostCode4Per { get; set; }
        public float CostCode5Per { get; set; }
        public bool InUse { get; set; }
        public string Manager { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedUser { get; set; }
        public DateTime CreatedDate { get; set; }        
    }
}
