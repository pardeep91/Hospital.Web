using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.DAL.IDAL;
using Hospital.DTO;
using System.Data.Entity;
using System.Web.Security;


namespace Hospital.DAL.DAL
{
   public class UserloginDAL : IUserloginDAL
    {
        private HospitalEntities dbcontext = new HospitalEntities();
        public bool Dologin(UserDTO chklogin)
        {
            //User login = new User();
            //login.User_Name = chklogin.User_Name;
            //login.User_Password = chklogin.User_Password;
            //var login = (from frm in dbcontext.Users.ToList()
            //         where frm.User_Name == chklogin.User_Name && frm.User_Password == chklogin.User_Password && frm.User_IsActive == true
            //         select frm).Single();
            var login = dbcontext.Users.Where(frm=>frm.User_Name == chklogin.User_Name && frm.User_Password == chklogin.User_Password && frm.User_IsActive == true).FirstOrDefault() ;

            if (login != null)
                 
            {
                FormsAuthentication.SetAuthCookie(login.User_Name, false);
                return true;
            }
            else
            {
                
                return false;
            }
            
        }
    }
}
