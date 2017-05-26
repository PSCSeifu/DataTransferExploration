using EESetup.Types;
using EESetup.Types.dto;
using EESetup.Types.MstrTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EESetup.Types.Enums.Enums;

namespace EESetup.Export
{
    public class MstrBuilder
    {

        public void Export()
        {
            List<dtoMstr> dtoList = Repo.GetData();

            List<MstrBM> mstrBMList = MapToToBM(dtoList);

            //CreateMstrCsv(fileName,mstrBMList);
            
        }

        private List<MstrBM> MapToToBM(List<dtoMstr> dtoList)
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
                mstrBM.BirthDate = new BirthDate(dto.BirthDate, "dd/MM/yyyy");
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
