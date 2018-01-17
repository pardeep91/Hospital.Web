using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Services.Iservices;
using Hospital.DAL.IDAL;
using Hospital.DAL.DAL;
using Hospital.DTO;

namespace Hospital.Services.Services
{
    public class SignupServices : ISignupServices
    {
        private readonly IMembershipSignupDAL _IMembershipDAL;
        public SignupServices()
        {
            _IMembershipDAL = new MembershipSignupDAL();
        }

        public void Signup(UserDTO signup)
        {
            _IMembershipDAL.Signup(signup);
        }
    }
}
