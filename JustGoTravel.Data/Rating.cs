using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustGoTravel.Data
{
   public class Rating
    {
        [Key]
        public int ID { get; set; }

        [Required, Range(0, 5, ErrorMessage ="Please choose a number betwen 0 and 5")]
        public double StarRating { get; set; }

        public Guid AuthorID { get; set; }
        public ICollection<VacationPack> VacationPacks { get; set; }
    }
}
