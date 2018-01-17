using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.DAL;
using Hospital.DAL.DAL;
using Hospital.DAL.IDAL;
using Hospital.DTO;
using Hospital.Services.Iservices;

namespace Hospital.Services.Services
{
    public class employeeServices : IemployeeServices
    {
        private readonly IEmployeeDAL _employeeDal;
        public employeeServices()
        {
            _employeeDal = new EmployeeDAL();
        }

        

        public void Create(EmployeeDTO emp)
        {
            _employeeDal.Create(emp);
        }

        public void Delete(int id)
        {
            _employeeDal.Delete(id);
        }

        public EmployeeDTO GetById(int id)
        {
         return   _employeeDal.GetById(id);
        
        }

        public List<EmployeeDTO> GetEmployee()
        {
            return _employeeDal.GetEmployee();
        }
        //public List<UserDTO> Getusers()

    }
}
