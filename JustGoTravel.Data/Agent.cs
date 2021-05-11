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

        [Required, Display(Name = "First Name")]
        [StringLength(25, MinimumLength = 3, ErrorMessage ="Fist name should be between 3-25 characters")]
        public string FirstName { get; set; }

        [Required, Display(Name = "Last Name")]
        [StringLength(25, MinimumLength =3, ErrorMessage = "Fist name should be between 3-25 characters")]
        public string LastName { get; set; }

        [Display(Name = "Company")]
        public string Company { get; set; }

        [Required, Display(Name = "Phone Number")]
        [MaxLength(15, ErrorMessage ="Sorry to many Numbers")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required, Display(Name ="Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name ="LinkedIn")]
        public string LinkedIn { get; set; }
        public Guid AuthorId { get; set; }
        public ICollection<VacationPack> VacationPacks { get; set; }  
    }
}
