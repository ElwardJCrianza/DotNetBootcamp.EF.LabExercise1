using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class Schedule
    {
        [Key]
        public int ScheduleID { get; set; }

        public int Day { get; set; }

        public decimal HourlyWage { get; set; }

        public bool OverTime { get; set; }

        //Foreign keys
        public int ShiftID { get; set; }
        public Shift Shift { get; set; }

        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }


    }
}
