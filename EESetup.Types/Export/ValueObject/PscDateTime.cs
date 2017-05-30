using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESetup.Types.MstrTypes
{
    public abstract class PscDateTime
    {
        private readonly string _Format;
        private readonly DateTime _Value;
        private readonly string _StringValue;

        public PscDateTime()
        {
            this._Format = "";
            this._StringValue = "";
            this._Value = DateTime.MinValue;
        }

        public PscDateTime(DateTime value, string format)
        {
            this._Format = format;
            this._StringValue = value.ToString(format);
            this._Value = value;
        }

        public string GetString()
        {
            return this._StringValue;
        }
    }
}
