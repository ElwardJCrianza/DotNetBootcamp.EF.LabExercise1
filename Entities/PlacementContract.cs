using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class PlacementContract
    {
        [Key]
        public int PlacementContractID { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //Foreign key
        public int LocationId { get; set; }

        public Location Location { get; set; }

        //Relationship with Shifts
        public ICollection<Shift> Shifts { get; set; }
    }
}
