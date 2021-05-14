using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustGoTravel.Models.VacationPack
{
   public class VacationPackCreate
    {

        [Required]
        [StringLength(100, ErrorMessage = "Sorry you entered to many Charachers")]
        public string Title { get; set; }

        [Required]
        public int TripLength { get; set; }

        [Required]
        public double TotalCost { get; set; }

        [Required]
        public string Location { get; set; }

        public string Description { get; set; }

        [Required]
        public string Included { get; set; }



    }
}
