using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.DAL.IDAL;
using Hospital.DTO;

namespace Hospital.DAL.DAL
{

    public class EmployeeDAL : IEmployeeDAL
    {
        private HospitalEntities dbcontext = new HospitalEntities();
        public void Create(EmployeeDTO empdt)
        {

            Employee emp = new Employee();
            emp.FirstName = empdt.FirstName;
            emp.LastName = empdt.LastName;
            emp.Phone = empdt.Phone;
            emp.Status = empdt.Status;
            emp.Title = empdt.Title;

            if (empdt.Id > 0)
            {
                emp.Id = empdt.Id;

                dbcontext.Entry(emp).State = EntityState.Modified;
            }
            else
            {
                dbcontext.Employees.Add(emp);
                
            }

            dbcontext.SaveChanges();

        }

        public void Delete(int id)
        {
            var Delete_emp = dbcontext.Employees.Find(id);

           if( Delete_emp.Id>0)
            {

                dbcontext.Employees.Remove(Delete_emp);

            }
            dbcontext.SaveChanges();
        }

        public EmployeeDTO GetById(int id)
        {
            var getdat = dbcontext.Employees.Where(frm => frm.Id == id).FirstOrDefault();

            EmployeeDTO employeeDTO = new EmployeeDTO();
            employeeDTO.Id = getdat.Id;
            employeeDTO.FirstName = getdat.FirstName;
            employeeDTO.LastName = getdat.LastName;
            employeeDTO.Phone = getdat.Phone;
            employeeDTO.Status = getdat.Status;
            employeeDTO.Title = getdat.Title;
            return employeeDTO;
        }

        public List<EmployeeDTO> GetEmployee()
        {
            var list = dbcontext.Employees.ToList();
            List<EmployeeDTO> clientList = null;
            if (list != null && list.Count > 0)
            {
                clientList = new List<EmployeeDTO>();
                foreach (var item in list)
                {
                    EmployeeDTO emp = new EmployeeDTO();
                    emp.Id = item.Id;
                    emp.FirstName = item.FirstName;
                    emp.LastName = item.LastName;
                    emp.Phone = item.Phone;
                    emp.Status = item.Status;
                    emp.Title = item.Title;
                    clientList.Add(emp);

                }
            }
            return clientList;
        }
      




    }
}
