//using System;
//using System.Net.Mail;
//using ITech_Project.ViewModels;

//namespace ITech_Project.Email
//{
//    public class EmailHelper
//    {
//        public bool SendEmailPasswordReset(ForgetPasswordViewModel userEmail)
//        {
//            MailMessage mailMessage = new MailMessage();
//            mailMessage.From = new MailAddress("care@yogihosting.com");
//            mailMessage.To.Add(new MailAddress(userEmail));

//            mailMessage.Subject = "Password Reset";
//            mailMessage.IsBodyHtml = true;
//            //mailMessage.Body = link;

//            SmtpClient client = new SmtpClient();
//            client.Credentials = new System.Net.NetworkCredential("care@yogihosting.com", "yourpassword");
//            client.Host = "smtpout.secureserver.net";
//            client.Port = 80;

//            try
//            {
//                client.Send(mailMessage);
//                return true;
//            }
//            catch (Exception ex)
//            {
//                // log exception
//            }
//            return false;
//        }
//    }
//}
