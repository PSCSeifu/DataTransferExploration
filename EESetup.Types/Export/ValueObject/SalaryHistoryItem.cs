using System;

namespace EESetup.Types.Export.ValueObject
{
    public class SalaryHistoryItem
    {
        private const string EffectiveDateFormat = "dd/MM/yyyy";

        private readonly int _Id;
        private readonly DateTime _EffectiveDate;
        private readonly double _Salary;
        private readonly double _ContractedHours;
        private readonly double HourlyRate;
        private readonly string _EffectiveDateString;

        public SalaryHistoryItem()
        {
            this._Id = 0;
            this._EffectiveDate = DateTime.MinValue;
            this._EffectiveDateString = "";
            this._Salary = 0.0;
            this._ContractedHours = 0.0;
            this.HourlyRate = 0.0;
        }

        internal object GetId()
        {
            return this._Id;
        }

        public SalaryHistoryItem(int id,DateTime effectiveDate, double salary, double contractedHours, double hourlyRate)
        {
            this._Id = id;
            this._EffectiveDate = effectiveDate;
            this._EffectiveDateString = effectiveDate.ToString(EffectiveDateFormat);
            this._Salary = salary;
            this._ContractedHours = contractedHours;
            this.HourlyRate = hourlyRate;
        }

        public string ToLine()
        {
            return $"{this._EffectiveDateString};{this._Salary.ToString()};{this._ContractedHours.ToString()};{this.HourlyRate.ToString()}";
        }

        public string GetEffectiveDate()
        {
            return this._EffectiveDateString;
        }

        
        
    }
}