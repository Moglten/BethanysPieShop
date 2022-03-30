using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.SendEmailHelper
{
    interface IEmailService
    {
        public void SendToCustomer() { }

        public void ReciveTheMessage() { }
    }
}
