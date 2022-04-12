using Microsoft.AspNetCore.Mvc;
using System;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using Microsoft.AspNetCore.Identity;

namespace website.Controllers
{
     
    public class EmailController : Controller
    {
        public IActionResult Index(string firstName, string lastName, string email)
        {
        
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("BlueAvans", "verzenden2@gmail.com"));
            message.To.Add(MailboxAddress.Parse(email));

            message.Subject = "Uw bioscoopkaartje van BlueAvans";
            String text = "Beste " + firstName + " " + lastName + ",\n\nHierbij ontvangt u de bevestiging van uw aankoop.\nHierin staat een QR-code weergegeven.Scan deze code bij de bioscoop en print het kaartje. U bent geholpen door: " + User.Identity.Name;
            
            TextPart body = new TextPart("plain");
            body.SetText("utf-16", text);

            var builder = new BodyBuilder();
            builder.TextBody = text;
            builder.Attachments.Add(@"Image/QR-code.png");
            message.Body = builder.ToMessageBody(); 

            SmtpClient smtpClient = new SmtpClient();

            try
            {
                smtpClient.Connect("smtp.gmail.com", 465, true);
                smtpClient.Authenticate("verzenden2@gmail.com", "Welkom123!");
                smtpClient.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                smtpClient.Disconnect(true);
                smtpClient.Dispose();
            }

            ViewBag.FN = firstName;
            ViewBag.LN = lastName;
            ViewBag.Email = email;
            return View();
        }
    }
}
