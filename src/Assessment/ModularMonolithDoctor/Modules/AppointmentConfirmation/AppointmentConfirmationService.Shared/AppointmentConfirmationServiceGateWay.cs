using AppointmentConfirmation.API;

namespace AppointmentConfirmationService.Shared
{
    public class AppointmentConfirmationServiceGateWay
    {
        public void NotificationGateway(NotificationMessage notificationMessage)
        {
            ConfirmationNotificationService confirmationNotificationService = new ConfirmationNotificationService();


            confirmationNotificationService.Notify($"Hi {notificationMessage.PatientName}, your Appointment has been confirmed with doctor {notificationMessage.DoctorName} at {notificationMessage.Time}");
        }
    }
}
