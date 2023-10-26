using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SendMail
    {
        private String mail = "huuloctran129@gmail.com";
        public SendMail() { }

        public Boolean sendEmail(String to, String otp)
        {
            to = to.Trim();

            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(to);
            mailMessage.From = new MailAddress(mail);
            mailMessage.Subject = "Mã xác nhận tạo tài khoản";
            mailMessage.Body = "Mã xác nhận: " + otp;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(mail, "npgt doca wvpr qzhw");

            try
            {
                smtpClient.Send(mailMessage);
                return true;
            }

            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
