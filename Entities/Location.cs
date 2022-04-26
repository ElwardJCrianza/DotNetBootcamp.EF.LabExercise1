using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Street { get; set; }
        
        [Required]
        [MaxLength(30)]
        public string City { get; set; }

        [Required]
        [MaxLength(2)]
        public char Province { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Contact { get; set; }

        [Required]
        [MaxLength(12)]
        public string Phone { get; set; }

        public bool Active { get; set; }

        //Set relationship with PlacementContracts

        public ICollection<PlacementContract> PlacementContracts { get; set; }

    }
}
