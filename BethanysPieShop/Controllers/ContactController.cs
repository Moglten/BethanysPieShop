using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.SendEmailHelper;
using FluentEmail.Core;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanysPieShop.Controllers
{
    public class ContactController : Controller
    {
        private readonly IFluentEmail fluentEmailInstanceToMe;
        private readonly IFluentEmail fluentEmailInstanceToCustomer;

        public ContactController(IFluentEmail MineEmail,IFluentEmail CustomerEmail)
        {
            fluentEmailInstanceToMe = MineEmail;
            fluentEmailInstanceToCustomer = CustomerEmail;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendingEmail(EmailInfo emailInfo)
        {
            
            var email = new EmailService(fluentEmailInstanceToMe, fluentEmailInstanceToCustomer);

            email.ReciveTheMessage(emailInfo);

            email.SendToCustomer(emailInfo);

            ViewBag.Name = emailInfo.Name; 

            return View("CompleteSend");
        }
    }
}
