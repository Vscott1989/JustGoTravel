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
