using Hospital.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.IDAL
{
    public interface IEmployeeDAL
    {
        void Create(EmployeeDTO emp);
        void Delete(int id);
        EmployeeDTO GetById(int id);
        List<EmployeeDTO> GetEmployee();
    }
}
