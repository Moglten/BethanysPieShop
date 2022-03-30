using FluentEmail.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.SendEmailHelper
{
    public class EmailService : IEmailService
    {   
    
        private readonly IFluentEmail _ToCustomer;
        private readonly IFluentEmail _ToMe;
        public EmailService(IFluentEmail EmailToCustomer, IFluentEmail EmailToMe)
        {
            _ToCustomer = EmailToCustomer;
            _ToMe = EmailToMe;
        }

        public async void SendToCustomer(EmailInfo emailInfo)
        {
            //Sending comfirmation to the customer
           await _ToCustomer
                  .To(emailInfo.Email, "BethanysPieShop")
                  .Subject($"Thank You for reaching out {emailInfo.Name}")
                  .Body($"<p>Dear {emailInfo.Name} ,</p><br/>" +
                                "<p>Your message is recieved ,and the respone will reach you very soon</p><br/>" +
                                "<p>In Your Service, Bethanys Pie Shop</p>")
                  .SendAsync();
        }

        public async void ReciveTheMessage(EmailInfo emailInfo) 
        {
            await _ToMe
                .To("xgameplayer.com@gmail.com", "BethanysPieShop")
                .Subject($"BethanyPie Customers Email from {emailInfo.Email}")
                .Body($"The Customer {emailInfo.Name},<br/> Send From Email {emailInfo},<br/> message require about {emailInfo.Message}")
                .SendAsync();
        }
    }
}
