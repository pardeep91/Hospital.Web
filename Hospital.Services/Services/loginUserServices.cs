using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.DTO;
using Hospital.Services.Iservices;
using Hospital.DAL.DAL;
using Hospital.DAL.IDAL;

namespace Hospital.Services.Services
{
    public class loginUserServices : IloginUserServices
    {
        private readonly IUserloginDAL _UserloginDAL;
        public loginUserServices()
        {
            _UserloginDAL = new UserloginDAL();
        }
    
        public bool Dologin(UserDTO chklogin)
        {
           return _UserloginDAL.Dologin(chklogin);
        }
    }
}
