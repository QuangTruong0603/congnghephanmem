using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{


    public class BLL_Register
    {

        private DAL_Staff dalStaff = new DAL_Staff();
        public BLL_Register() { }


        public Boolean checkFormatEmail(String email)
        {
            bool status = true;
            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch { status = false; }

            return status;
        }

        public Boolean checkPassword(String password)
        {

            if(password.Length < 8)
            {
                return false;
            }

            if (!password.Any(char.IsUpper))
            {
                return false;
            }

            if (!password.Any(char.IsLower))
            {
                return false;
            }

            if (password.Contains(" "))
            {
                return false;
            }

            char[] pass = password.ToCharArray();
            bool checknumber = false;
            foreach (char ch in pass)
            {
                if (Char.IsDigit(ch))
                {
                    checknumber = true;
                    break;
                }

            }

            if(checknumber == false)
            {
                return false;
            }

            string specialCh = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] specialch = specialCh.ToCharArray();
            foreach (char ch in specialch)
            {
                if (password.Contains(ch))
                {
                    return true;
                }
                    
            }

            return false;


        }


        public String checkNewStaff(String email, String username, String password, String confirm)
        {
           if(email == "" || username == "" || password =="")
            {
                return "Vui lòng nhập đầy đủ thông tin để đăng ký";
            }
           else
            {
                if (password != confirm)
                {
                    return "Vui lòng xác nhận lại mật khẩu";
                }
                else
                {
                    if (checkFormatEmail(email) == false)
                    {
                        return "Định dạng email không chính xác";
                    }

                    if (checkPassword(password) == false)
                    {
                        return "Mật khẩu không hợp lệ. Mật khẩu phải có ít nhất 8 ký tự, chứa chữ hoa, chữ thường, chữ số, ký tự đăc biệt và không chứa khoảng trắng ";
                    }





                    if(dalStaff.checkUserByUsername(username) != 0) 
                    {
                        return "Tên tài khoản đã tồn tại";
                    }

                    return "OK";


                }


            }
        } 

        public Boolean addNewStaff(String username, String password, String email) 
        {
            return dalStaff.addStaff(username, password, email);
        }
    }
}
