using Daawahla.Application.Interfaces.IMailService;
using Daawahla.Core.Entities.Mail;
using log4net;
using MailKit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Daawahla.WebApi.Controllers.api.EmailApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(EmailController));
        private readonly IMailRepository _mailRepository;
        public EmailController(IMailRepository mailRepository)
        {
            this._mailRepository = mailRepository;
        }

        [HttpPost("Send")]
        public async Task<IActionResult> Send([FromForm] MailRequest request)
        {
            try
            {
                await _mailRepository.SendEmailAsync(request);
                return Ok();
            }
            catch (Exception ex)
            {

                log4net.GlobalContext.Properties["username"] = "Ahmad Zeb";
                log.Info(ex.Message);
                throw;
            }

        }
    }
}
