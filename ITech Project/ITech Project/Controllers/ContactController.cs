using System.IO;
using ITech_Project.ViewModels;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;


using Microsoft.AspNetCore.Mvc;
using ITech_Project.Services;

namespace ITech_Project.Controllers
{
    public class ContactController : Controller
    {


        private readonly IMailingService _mailingService;

        public ContactController(IMailingService mailingService)
        {
            _mailingService = mailingService;
        }

        public IActionResult SendMail()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> SendMail([FromForm] MailRequestDto dto)
        {
            await _mailingService.SendEmailAsync(dto.ToEmail, dto.Subject, dto.Body, dto.Attachments);

            return RedirectToAction("EmailSent", dto);
        }

        [Route("EmailSent")]
        public IActionResult EmailSent(MailRequestDto dto)
        {
            return View(dto);
        }
    }

}

