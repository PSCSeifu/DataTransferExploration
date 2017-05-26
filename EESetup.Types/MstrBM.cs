using EESetup.Types.MstrTypes;

namespace EESetup.Types
{
    public class MstrBM
    {
        public string EmployeeNo { get; set; }
        public string Surname { get; set; }
        public string Initials { get; set; }
        public Title Title { get; set; }
        public Department Department { get; set; }
        public BirthDate BirthDate { get; set; }
        public SalaryHistory SalaryHistory { get; set; }
        public bool IsUkWorker { get; set; }
    }
}
