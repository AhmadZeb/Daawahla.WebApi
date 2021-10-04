using Daawahla.Core.Entities.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daawahla.Application.Interfaces.IMailService
{
    public interface IMailRepository
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
