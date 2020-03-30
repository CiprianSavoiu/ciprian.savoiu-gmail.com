using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community.Map.Models
{
    public class MainHelp
    {
        public List<HelpOffer> HelpOffers { get; set; }
        public List<HelpRequest> HelpRequests { get; set; }

        public HelpRequest HelpRequest = new HelpRequest();
        public HelpOffer HelpOffer = new HelpOffer();
    }
}
