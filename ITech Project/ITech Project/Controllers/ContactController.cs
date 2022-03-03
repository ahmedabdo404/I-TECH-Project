using System.IO;
using ITech_Project.ViewModels;
using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;


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
        public async Task<IActionResult> Index(ContactFormViewModel model)
        {
            //Read SMTP settings from AppSettings.json.
            string host = this.Configuration.GetValue<string>("Smtp:Server");
            int port = this.Configuration.GetValue<int>("Smtp:Port");
            string fromAddress = this.Configuration.GetValue<string>("Smtp:FromAddress");
            string userName = this.Configuration.GetValue<string>("Smtp:UserName");
            string password = this.Configuration.GetValue<string>("Smtp:Password");

            using (MailMessage mm = new MailMessage(fromAddress, "itech0638@gmail.com"))
            {
                mm.Subject = "";
                mm.Body = string.Format("<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>", model.Name, model.Email, model.Message);
                mm.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Host = host;
                    smtp.EnableSsl = true;
                    NetworkCredential NetworkCred = new NetworkCredential(userName, password);
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = NetworkCred;
                    smtp.Port = port;

                    await smtp.SendMailAsync(mm);
                    ViewBag.Message = "Email sent sucessfully.";
                }
            }
            return View(model);
        }


        //[HttpGet]
        //public IActionResult Contact()
        //{
        //    return View();
        //}



        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Contact(ContactFormViewModel model)
        //{

        //    string host = this.Configuration.GetValue<string>("Smtp:Server");
        //    int port = this.Configuration.GetValue<int>("Smtp:Port");
        //    string fromAddress = this.Configuration.GetValue<string>("Smtp:FromAddress");
        //    string userName = this.Configuration.GetValue<string>("Smtp:UserName");
        //    string password = this.Configuration.GetValue<string>("Smtp:Password");
        //    if (ModelState.IsValid)
        //    {
        //        var mail = new MailMessage();
        //        mail.To.Add(new MailAddress(model.Email));
        //        mail.Subject = "Your Email Subject";
        //        mail.Body = string.Format("<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>", model.Name, model.Email, model.Message);
        //        mail.IsBodyHtml = true;
        //        using (var smtp = new SmtpClient())
        //        {

        //            //smtp.Host = host;
        //            smtp.EnableSsl = true;
        //            NetworkCredential NetworkCred = new NetworkCredential(userName, password);
        //            smtp.UseDefaultCredentials = true;
        //            smtp.Credentials = NetworkCred;
        //            //smtp.Port = port;
        //            await smtp.SendMailAsync(mail);

        //            return RedirectToAction("SuccessMessage");
        //        }
        //    }
        //    return View(model);
        //}

        //public ActionResult SuccessMessage()
        //{
        //    return View();
        //}
    }
}
