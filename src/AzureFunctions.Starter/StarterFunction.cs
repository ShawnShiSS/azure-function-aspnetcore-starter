using AzureFunctions.Core.Interfaces.Email;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;

namespace AzureFunctions.Starter
{
    public class StarterFunction
    {
        private readonly ILogger<StarterFunction> _log;
        private readonly IEmailService _emailService;

        public StarterFunction(ILogger<StarterFunction> log,
                               IEmailService emailService)
        {
            this._log = log ?? throw new ArgumentNullException(nameof(log));
            this._emailService = emailService ?? throw new ArgumentNullException(nameof(emailService));

        }

        [FunctionName("StarterFunction")]
        public void Run([TimerTrigger("0 */5 * * * *", RunOnStartup = true)]TimerInfo myTimer)
        {
            _log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
