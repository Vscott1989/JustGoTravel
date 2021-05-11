using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustGoTravel.Data
{
   public class Agent
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Company")]
        public string Company { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public int PhoneNumber { get; set; }

        [Required]
        [Display(Name ="Email")]
        public string Email { get; set; }

        [Display(Name ="LinkedIn")]
        public string LinkedIn { get; set; }
        public Guid AuthorId { get; set; }
        public ICollection<VacationPack> VacationPacks { get; set; }
    }
}
