using OnionAPI.Application.Abstractions.ExternalServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Infrastructure.ExternalService
{
    internal class EmailNotificationService : INotificationService
    {
        public void SentMessage(string to, string message)
        {
            throw new NotImplementedException();
        }
    }
}
