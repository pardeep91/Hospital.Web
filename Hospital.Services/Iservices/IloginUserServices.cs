using Hospital.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Services.Iservices
{
   public interface IloginUserServices
    {
        bool Dologin(UserDTO chklogin);
    }
}
