using System.IO;
using ITech_Project.ViewModels;
using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Configuration;

using Microsoft.AspNetCore.Mvc;

namespace ITech_Project.Controllers
{
    public class ContactController : Controller
    {
        private IConfiguration Configuration;
        public ContactController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }


        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(ContactFormViewModel model)
        {
            //Read SMTP settings from AppSettings.json.
            string host = this.Configuration.GetValue<string>("Smtp:Server");
            int port = this.Configuration.GetValue<int>("Smtp:Port");
            string fromAddress = this.Configuration.GetValue<string>("Smtp:FromAddress");
            string userName = this.Configuration.GetValue<string>("Smtp:UserName");
            string password = this.Configuration.GetValue<string>("Smtp:Password");

            using (MailMessage mm = new MailMessage(fromAddress, "admin@aspsnippets.com"))
            {
                mm.Subject = model.Subject;
                mm.Body = "Name: " + model.Name + "<br /><br />Email: " + model.Email + "<br />" ;
                mm.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient())
                {
                    smtp.Host = host;
                    smtp.EnableSsl = true;
                    NetworkCredential NetworkCred = new NetworkCredential(userName, password);
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = NetworkCred;
                    smtp.Port = port;
                    smtp.Send(mm);
                    ViewBag.Message = "Email sent sucessfully.";
                }
            }

            return View();
        }
    }
}
