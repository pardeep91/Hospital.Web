using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DTO
{
   public class UserDTO
    {
         
        public int User_ID { get; set; }
        public string User_Name { get; set; }
        public string User_Password { get; set; }
        public bool? User_IsActive { get; set; }
    }
}

