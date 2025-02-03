
using Microsoft.Extensions.Logging;

namespace AppointmentConfirmation.API
{

    public class ConfirmationNotificationService
    {
      

        public ConfirmationNotificationService()
        {

        }

        public void Notify(string msg)
        {
            System.Console.WriteLine(msg);
        }

    }
}
