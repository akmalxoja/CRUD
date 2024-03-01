using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSendlerApplication.Services
{
    namespace EmailSenderApp.Application.Services.Email
    {
        public interface IEmailService
        {
            Task SendEmailAsync(EmailModel model);
            Task<bool> CheckEmailAsync(string code);
            Task SetPassword(User user);
            Task<bool> IsUserRegistered(string email);
            Task<bool> VerifyCredentials(User user);
        }
    }
}
