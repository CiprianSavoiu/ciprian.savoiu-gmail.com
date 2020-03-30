using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community.Map.Models
{
    public class HelpRequest : ICommunityHelper
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter the Your Name or Business Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the Your Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter the Your Phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please enter the Your Request Message")]
        public string Notes { get; set; }
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }
        public HelpCategory Category { get; set; }

        public bool IsUrgent { get; set; }
        public bool IsAbleCollect { get; set; }
    }
}
