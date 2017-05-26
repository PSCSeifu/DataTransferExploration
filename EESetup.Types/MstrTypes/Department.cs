namespace EESetup.Types.MstrTypes
{
    public class Department
    {
        private readonly int _Code;
        private readonly string _Name;
        private int departmentNo;

        public Department()
        {
            this._Code = 0;
            this._Name = "";
        }

        public Department(int code, string name)
        {
            this._Code = code;
            this._Name = name;
        }

        public string GetDepartment()
        {
            return $"{this._Code.ToString()}:{this._Name}";
        }
    }
}