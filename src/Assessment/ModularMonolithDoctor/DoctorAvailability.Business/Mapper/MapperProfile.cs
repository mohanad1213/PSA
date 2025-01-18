using AutoMapper;
using DoctorAvailability.Business.Dtos;
using DoctorAvailability.Data.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAvailability.Business.Mapper
{
    internal class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<TimeSlot, TimeSlotModel>().ReverseMap();
            CreateMap<IEnumerable<TimeSlot>, IEnumerable<TimeSlotModel>>().ReverseMap();
        }
    }
}
