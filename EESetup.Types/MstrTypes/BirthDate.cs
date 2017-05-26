using EESetup.Types.MstrTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESetup.Types.MstrTypes
{
    public class BirthDate : PscDateTime
    {
        public BirthDate(DateTime value, string format) : base(value, format)
        {
        }
    }
}
