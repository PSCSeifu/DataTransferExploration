using System;
using static EESetup.Types.Enums.Enums;

namespace EESetup.Types.MstrTypes
{
    public class Title
    {
        private readonly string _Description;
        private readonly int _Id;

        public Title()
        {
            this._Description = "";
            this._Id = 0;
        }

        public Title( int id, string description)
        {
            this._Description = description;
            this._Id = id;
        }

        public Title(int id)
        {
            this._Description = GetDescription(id);
            this._Id = id;
        }

        private string GetDescription(int id) => ((PscPayrollTitle)id).ToString();

        public string GetTitle()
        {
            return this._Description;
        }
    }
}
