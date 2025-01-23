using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    public class TimeSlotEntities
    {
        [Key]
        public Guid id { get; set; }
        public DateTime time { get; set; }
        public Guid doctorId { get; set; }
        public string doctorName { get; set; }
        public bool isReserved { get; set; }
        public decimal cost { get; set; }
    }
}
