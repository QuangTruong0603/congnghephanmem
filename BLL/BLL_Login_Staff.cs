using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class BLL_Login_Staff
    {
        DAL_Staff staff = new DAL_Staff();
        
        public String checkLogin(string username, string password)
        {
            return staff.checkLogin(username, password);
        }
        
    }
   

}
