using HotBooking.Domain;
using HotBooking.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace HotBooking.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;

            ViewBag.Culture = culture;

            return View(dataManager);
        }

        public IActionResult Country(Guid countryId)
        {
            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;

            ViewBag.Culture = culture;

            var country = dataManager.Countries.GetByIdAndCulture(countryId, culture);
            return View(country);
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMail(string name, string email, string phone, string message)
        {
            MimeMessage finalMessage = new MimeMessage();

            MailboxAddress from = new MailboxAddress(name, email);
            finalMessage.From.Add(from);

            MailboxAddress to = new MailboxAddress("Admin", "art.zaqaryan02@gmail.com");
            finalMessage.To.Add(to);

            finalMessage.Subject = $"HotBooking user` {name}, email` {email}, phone` {phone}.";

            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = $"<p>{message}</p>";
            bodyBuilder.TextBody = message;

            finalMessage.Body = bodyBuilder.ToMessageBody();

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587);
            client.Authenticate("art.zaqaryan02@gmail.com", "ykrwwizfkmpbywrg");

            client.Send(finalMessage);
            client.Disconnect(true);
            client.Dispose();

            return View();
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }
    }
}
