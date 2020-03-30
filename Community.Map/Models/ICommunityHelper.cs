using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community.Map.Models
{
    public interface ICommunityHelper
    {
        int Id { get; set; }
        string Name { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
        string Notes { get; set; }

        double Latitude { get; set; }
        double Longitude { get; set; }

        HelpCategory Category { get; set; }
    }
    public enum HelpCategory
    {
        Shopping,
        Medication,
        Financial,
        Other
    }
}
