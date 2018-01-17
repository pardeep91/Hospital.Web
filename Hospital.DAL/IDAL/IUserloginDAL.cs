using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.DTO;

namespace Hospital.DAL.IDAL
{
   public interface IUserloginDAL
    {
        bool Dologin(UserDTO chklogin);
    }
}
