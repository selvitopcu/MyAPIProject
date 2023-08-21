using HotelProject.WebUI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace HotelProject.WebUI.Controllers
{
    public class AdminMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AdminMailViewModel model)
        {
            MimeMessage mimeMessage=new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("HotellerAdmin","burası bizim mailimiz");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressto = new MailboxAddress("User", model.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressto);

            var bodyBuilder=new BodyBuilder();
             bodyBuilder.TextBody = model.Body;
            mimeMessage.Subject = model.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("mail", "password key");
            client.Send(mimeMessage);
            client.Disconnect(true);
            return View();
        }
    }
}

//maildeneme012@gmail.com
