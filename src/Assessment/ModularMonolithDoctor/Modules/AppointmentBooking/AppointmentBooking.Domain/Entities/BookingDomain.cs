namespace AppointmentBooking.Domain.Entities
{
    public class BookingEntity
    {
        // Private fields
        private Guid id;
        private Guid slotId;
        private Guid patientId;
        private string patientName;
        private DateTime reservedAt;

        // Constructor for creating a reservation with all required fields
        private BookingEntity(Guid id, Guid slotId, Guid patientId, string patientName, DateTime reservedAt)
        {
            if (id == Guid.Empty) throw new ArgumentException("Id must not be empty.", nameof(id));
            if (slotId == Guid.Empty) throw new ArgumentException("SlotId must not be empty.", nameof(slotId));
            if (patientId == Guid.Empty) throw new ArgumentException("PatientId must not be empty.", nameof(patientId));
            if (string.IsNullOrWhiteSpace(patientName)) throw new ArgumentException("PatientName must not be empty.", nameof(patientName));
            if (reservedAt == default) throw new ArgumentException("ReservedAt must be a valid date.", nameof(reservedAt));

            this.id = id;
            this.slotId = slotId;
            this.patientId = patientId;
            this.patientName = patientName;
            this.reservedAt = reservedAt;

             // Factory method for creating a new reservation
        public static BookingEntity Create(Guid slotId, Guid patientId, string patientName, DateTime reservedAt)
        {
            return new BookingEntity(Guid.NewGuid(), slotId, patientId, patientName, reservedAt);
        }
    }

}

