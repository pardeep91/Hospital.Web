using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.DTO;

namespace Hospital.Services.Iservices
{
   public interface ISignupServices
    {
        void Signup(UserDTO signup);
    }
}
