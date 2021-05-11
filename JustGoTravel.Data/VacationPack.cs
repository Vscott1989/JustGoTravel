using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustGoTravel.Data
{
    public class VacationPack
    {
        [Key]
        public int ID { get; set; }

        [Required, Display (Name = "Vacation Package Name")]
        [StringLength(100, ErrorMessage ="Sorry you entered to many Charachers")]
        public string Name { get; set; }


        [Required, Display(Name ="Length of Trip")]
        public int TripLength { get; set; }


        [Required, Display(Name ="Total Cost")]
        public double TotalCost { get; set; }

        
        [Required, Display (Name ="City & Contry")]
        public string Location { get; set; }

        
        [Display(Name="Comment")]
        public string Description { get; set; }


        [Required, Display(Name = "What was Included in package?")]
        public string Included { get; set; }

        public DateTimeOffset TimeOfPublication { get; set; }
        public Guid AuthorId { get; set; }

        [Required]
        [ForeignKey(nameof(Rating))]
        public int? RatingID { get; set; }
        public virtual Rating Rating { get; set; }

        [Required]
        [ForeignKey(nameof(Agent))]
        public int? AgentID { get; set; }
        public virtual Agent Agent { get; set; }

    }
}
