using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace MyProtfolio.Models
{
    public class SendMailService
    {
        public string email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int User_Id { get; set; }
        public SendMailService(string email, string user_Name, string password, int id)
        {
            this.email = email;
            this.UserName = user_Name;
            this.Password = password;
            this.User_Id = id;
        }
        public void SendMail()
        {
            try
            {


                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("pragatikitukale2001@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Login Credentials";
                mail.Body = "<h2>Registration Completed!</h2><br>Your,<br><b>User_Name : </b>" + UserName + "<br>And<br><b>Password : </b>" + Password;
                mail.IsBodyHtml = true;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("pragatikitukale2001@gmail.com", "rlstmdoawenrjaje");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}