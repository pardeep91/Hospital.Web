using Hospital.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.IDAL
{
   public interface IMembershipSignupDAL
    {
        void Signup(UserDTO signup);
    }
}
