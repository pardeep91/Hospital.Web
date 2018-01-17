using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.DAL.IDAL;
using Hospital.DTO;
using System.Data.Entity;

namespace Hospital.DAL.DAL
{
   public class MembershipSignupDAL: IMembershipSignupDAL
    {
        private readonly HospitalEntities dbcontext = new HospitalEntities();
        public void Signup(UserDTO signup)
        {
            User users = new User();
            users.User_Name = signup.User_Name;
            users.User_Password = signup.User_Password;
            users.User_IsActive = signup.User_IsActive;

            if (signup.User_ID > 0)
            {
                users.User_ID = signup.User_ID;

                dbcontext.Entry(users).State = EntityState.Modified;
            }
            else
            {
                dbcontext.Users.Add(users);

            }

            dbcontext.SaveChanges();


        }
    }
}
