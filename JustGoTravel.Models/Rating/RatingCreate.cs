using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustGoTravel.Models.Rating
{
   public class RatingCreate
    {

        [Required, Range(0, 5, ErrorMessage = "Please choose a number betwen 0 and 5")]
        public double StarRating { get; set; }


    }
}
