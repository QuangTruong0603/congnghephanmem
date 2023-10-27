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

        private DAL_Staff dalstaff = new DAL_Staff();

        public BLL_Login_Staff() { }


        public String checkLogin(String username, String password)
        {
            if(username == "" || password == "")
            {
                return "Vui lòng nhập đầy đủ tên tài khoản và mật khẩu";
            }
            else
            {

                Boolean check = dalstaff.checkLogin(username, password);

                if(check)
                {
                    return "Thành công";
                }
                else
                {
                    return "Tên tài khoản hoặc mật khẩu không chính xác";
                }
            }
        }

        public int getRole(String username)
        {
            return dalstaff.GetRole(username);
        }

        public String getName(String username)
        {
            return dalstaff.GetNameStaff(username);
        }


     

    }
   

}
