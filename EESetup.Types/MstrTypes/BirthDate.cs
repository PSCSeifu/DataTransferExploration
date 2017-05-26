using EESetup.Types.MstrTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESetup.Types.MstrTypes
{
    public class BirthDate 
    {
        private const string _Format = "dd/MM/yyyy";
        private readonly DateTime _Value;
        private readonly string _StringValue;

        public BirthDate(DateTime value)
        {
            this._Value = value;
            this._StringValue = this._Value.ToString(_Format);
        }
       
    }
}
