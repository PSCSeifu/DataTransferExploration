using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EESetup.Types.Export.ValueObject
{
    public class SalaryHistory
    {
        private readonly List<SalaryHistoryItem> _Items;
        private readonly List<SalaryHistoryItem> _DeduplicatedItems;

        public SalaryHistory()
        {
            this._Items = new List<SalaryHistoryItem>();
        }

        public SalaryHistory(List<SalaryHistoryItem> salaryHistoryItems)
        {
            this._Items = salaryHistoryItems;
        }
        
        public string GetSalaryHistory()
        {
            DeduplicateSalaryHistory();
            StringBuilder sb = new StringBuilder();
            if (this._DeduplicatedItems != null && this._DeduplicatedItems.Count > 0)
            {                
                foreach (var item in this._DeduplicatedItems)
                {
                    if(sb.Length == 0)
                        { sb.Append($"{item.ToLine()}"); }
                    sb.Append($":{item.ToLine()}");
                }
            }
            return sb.ToString();
        }

         internal void DeduplicateSalaryHistory()
        {
            if (this._Items != null && this._Items.Count > 0)
            {
                this._Items.OrderByDescending(h => h.GetId());
                foreach (var item in _Items)
                {
                    if (!ContainsEffectiveDate(item.GetEffectiveDate()))
                        this._DeduplicatedItems.Add(item);
                }
            }
        }

        internal bool ContainsEffectiveDate(string date)
            =>  _Items.Where(h => h.GetEffectiveDate() == date).Any();        
    }
}
