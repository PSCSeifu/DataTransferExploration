using EESetup.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESetup.Import
{
    public class MstrReader
    {
        public void Import(string fileName)
        {
             List<MstrVM> mstrVMList = ReadMstrCsv(fileName);

             List<MstrBM> mstrBMList = MapToBM(mstrVMList);

            ImportDepartment(mstrBMList);
            ImportGrade(mstrBMList);
            ImportSite(mstrBMList);
            ImportPicklists(mstrBMList);
            ImportJobTitles(mstrBMList);
            ImportBankRecords(mstrBMList);
            ImportEmployees(mstrBMList);
        }

        private void ImportEmployees(List<MstrBM> mstrBMList)
        {
            throw new NotImplementedException();
        }

        private void ImportBankRecords(List<MstrBM> mstrBMList)
        {
            throw new NotImplementedException();
        }

        private void ImportJobTitles(List<MstrBM> mstrBMList)
        {
            throw new NotImplementedException();
        }

        private void ImportPicklists(List<MstrBM> mstrBMList)
        {
            throw new NotImplementedException();
        }

        private void ImportSite(List<MstrBM> mstrBMList)
        {
            throw new NotImplementedException();
        }

        private void ImportGrade(List<MstrBM> mstrBMList)
        {
            throw new NotImplementedException();
        }

        private void ImportDepartment(List<MstrBM> mstrBMList)
        {
            throw new NotImplementedException();
        }

        private List<MstrBM> MapToBM(List<MstrVM> mstrVMList)
        {
            throw new NotImplementedException();
        }

        private List<MstrVM> ReadMstrCsv(string fileName)
        {
            throw new NotImplementedException();
        }
    }


}
