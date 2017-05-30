using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESetup.Types.Import.ValueObject
{
    public class Title
    {
        private readonly string _Description;
        public int _PicklistId;

        public Title()
        {
            this._Description = "";
            this._PicklistId = 0;
        }

        public Title (string description)
        {
            this._Description = description;            
        }
                

        public void SetPickListId(int picklistId)
        {
            /*  BusinessLayer.GetPicklist - would attempt to match existing title in eservices,
             * else create the picklist and return the new picklist table Id    */

            //this._PicklistId = BusinessLayer.GetPicklist(picklistType, organisationId,  this._Description);
            _PicklistId = picklistId;
        }

        public override string ToString()
        {
            return this._PicklistId.ToString();
        }
    }
}
