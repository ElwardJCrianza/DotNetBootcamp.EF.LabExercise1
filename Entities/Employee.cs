using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(12)]
        public char HomePhone { get; set; }

        public bool Active { get; set; }

        //Connect to Employee Skills Table
        public ICollection<EmployeeSkill> EmployeeSkills { get; set; }

        //Connect to Schedules
        public ICollection<Schedule> Schedules { get; set; }
    }
}
