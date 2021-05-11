using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustGoTravel.Models.Rating
{
   public class RatingListItem
    {
        
        public int ID { get; set; }

        [Display(Name ="StarRating (0-5)")]
        public double StarRating { get; set; }


    }
}
