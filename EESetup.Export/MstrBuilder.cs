using EESetup.Types;
using EESetup.Types.Export.dto;
using EESetup.Types.Export.ValueObject;
using System;
using System.Collections.Generic;

namespace EESetup.Export
{
    public class MstrBuilder
    {

        public void Export(string fileName)
        {
            List<dtoMstr> dtoList = Repo.GetData();

            List<MstrBM> mstrBMList = MapToBM(dtoList);

            List<MstrVM> mstrVMList = MapToVM(mstrBMList);

            WriteMstrCsv(fileName, mstrVMList);
            
        }

        private void WriteMstrCsv(string fileName, List<MstrVM> mstrVMList)
        {
            //PscCsv.Write.CsvWriter writer = new  PscCsv.Write.CsvWriter();
            //PscCsv.Write.CsvRow.Create(provider ...
            //PscCsv.Write.CsvRow  headerRow = new   PscCsv.Write.CsvRow();
            //headerRow.AddCol("Header1");
            //headerRow.AddCol("Header2");
            //headerRow.AddCol("Header3");

            //...

            //writer.Write();

            throw new NotImplementedException();
        }

        private List<MstrVM> MapToVM(List<MstrBM> mstrBMList)
        {
            List<MstrVM> mstrVMList = new List<MstrVM>();
            foreach (var bm in mstrBMList)
            {
                MstrVM vm = new MstrVM();
                vm.EmployeeNo = bm.EmployeeNo;
                vm.Surname = bm.Surname;
                vm.Initials = bm.Initials;
                vm.Title = bm.Title.ToString();
                vm.Department = bm.Department.GetDepartment();
                vm.BirthDate = bm.BirthDate.GetBirthDate();
                vm.IsUkWorker = bm.IsUkWorker.ToString();
            }

            return mstrVMList;
        }

        private List<MstrBM> MapToBM(List<dtoMstr> dtoList)
        {
            List<MstrBM> mstrBMList = new List<MstrBM>();
            foreach (var dto in dtoList)
            {
                MstrBM mstrBM = new MstrBM();
                mstrBM.EmployeeNo = dto.EmployeeNo;
                mstrBM.Surname = dto.Surname;
                mstrBM.Initials = dto.Initials;
                mstrBM.Title = new Title(dto.Title);
                mstrBM.Department = new Department(dto.DepartmentNo, dto.DepartmentName);
                mstrBM.BirthDate = new BirthDate(dto.BirthDate);
                mstrBM.IsUkWorker = dto.IsUkWorker;

                mstrBMList.Add(mstrBM);
            }

            return mstrBMList;
        }
    }


    public static class Repo
    {
        public static List<dtoMstr> GetData()
        {
            List<dtoMstr> dtoList = new List<dtoMstr>();
            dtoList.Add(new dtoMstr("03/05/1968,,,5401,A,Scot-Test,1"));
            dtoList.Add(new dtoMstr("14/12/1978,,,5402,K,Test,1"));
            dtoList.Add(new dtoMstr("01/12/1979,2,deptName2,5405,L,Test,1"));
            dtoList.Add(new dtoMstr("05/10/1986,6,deptName2,5406,J M,Test,1"));
            dtoList.Add(new dtoMstr("10/10/1990,3,deptName3,5407,J A,Test,1"));
            dtoList.Add(new dtoMstr("01/05/1980,3,deptName3,5408,G,Test,1"));
            dtoList.Add(new dtoMstr("01/01/1998,,,5410,M,Test,0"));
            dtoList.Add(new dtoMstr("14/10/1959,,,5411,T,Test,0"));
            dtoList.Add(new dtoMstr("10/05/1974,6,deptName6,5412,S,Test,1"));
            return dtoList;
        }
    }


}
