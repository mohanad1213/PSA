using DoctorAvailability.Data.Abstraction;
using DoctorAvailability.Data.Dtos;
using In_MemoryDB.DB1;
using In_MemoryDB.DB1.Tables;
using System.Diagnostics;

namespace DoctorAvailability.Data
{
    public class TimeSlotRepo : ITimeSlotRepo
    {
        private readonly InMemoryDB1 _inMemoryDB1;
        public TimeSlotRepo(InMemoryDB1 inMemoryDB1)
        {
            this._inMemoryDB1 = inMemoryDB1;
        }

        public List<TimeSlotDto> AddNewTimeSlot(AddTimeSlotDto timeSlotDto)
        {
            TimeSlot timeSlotEntity = new TimeSlot
            {
                id = Guid.NewGuid(),
                time = timeSlotDto.time,
                doctorId = timeSlotDto.doctorId,
                doctorName = timeSlotDto.doctorName,
                isReserved = false, // by default the time slot is not reserved 
                cost = timeSlotDto.cost
            };

            var result = this._inMemoryDB1.timeSlots.Add(timeSlotEntity);

            this._inMemoryDB1.SaveChanges();

            return GetAllDoctorAvailabilityTimeSlot();
        }

        public List<TimeSlotDto> GetAllDoctorAvailabilityTimeSlot()
        {
            List<TimeSlotDto> list = new List<TimeSlotDto>();
            var result = this._inMemoryDB1.timeSlots.ToList();

            foreach (var item in result)
            {
                list.Add(new TimeSlotDto
                {
                    id = item.id,
                    time = item.time,
                    doctorId = item.doctorId,
                    doctorName = item.doctorName,
                    isReserved = item.isReserved,
                    cost = item.cost
                });
            }

            return list;
        }
    }
}
