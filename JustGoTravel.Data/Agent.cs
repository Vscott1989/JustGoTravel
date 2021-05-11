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
        
        public string FullName { get; set; }
        public string Company { get; set; }

        [Required]
        public int PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }
        public string LinkedIn { get; set; }
        public Guid AuthorId { get; set; }
        public ICollection<VacationPack> VacationPacks { get; set; }
    }
}
