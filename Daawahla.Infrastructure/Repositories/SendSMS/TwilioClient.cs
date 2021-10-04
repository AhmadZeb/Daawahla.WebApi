using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Clients;
using Twilio.Http;
using SystemHttpClient = System.Net.Http.HttpClient;

namespace Daawahla.Infrastructure.Repositories.SendSMS
{
    public class TwilioClient : ITwilioRestClient
    {
        private readonly ITwilioRestClient _client;

        public TwilioClient(IConfiguration config, SystemHttpClient client)
        {
            // customize
            client.DefaultRequestHeaders.Add("X-Custom-Header", "Twilio-SmsProject");

            _client = new TwilioRestClient(
                config["Twilio:AccountSid"],
                config["Twilio:AuthToken"],
                httpClient: new SystemNetHttpClient(client));
        }

        public Response Request(Request request) => _client.Request(request);
        public Task<Response> RequestAsync(Request request) => _client.RequestAsync(request);
        public string AccountSid => _client.AccountSid;
        public string Region => _client.Region;
        public Twilio.Http.HttpClient HttpClient => _client.HttpClient;
    }
}
