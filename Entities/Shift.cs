using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class Shift
    {
        [Key]
        public int ShiftID { get; set; }

        [Required]
        public int DayOfWeek { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public byte NumberOfEmployees { get; set; }

        public bool Active { get; set; }

        [MaxLength(100)]
        public string? Notes { get; set; }

        //Foreign key
        public int PlacementContractID { get; set; }

        public PlacementContract PlacementContract { get; set; }

        //Conjunction table for M2M Rel
        public ICollection<Schedule> Schedules { get; set; }

    }
}
