using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community.Map.Models
{
    public interface ICommunityRepository
    {
        Task<IEnumerable<HelpRequest>> GetRequestsAsync();
        Task<IEnumerable<HelpOffer>> GetHelpOffersAsync();
        HelpRequest GetRequest(int requestId);
        HelpOffer GetOffer(int offerId);

        HelpRequest AddRequest(HelpRequest helpRequest);
        HelpOffer AddOffer(HelpOffer helpOffer);

        HelpRequest DeleteRequest(int requestId);
        HelpOffer DeleteOffer(int offerId);

        HelpRequest UpdateRequest(HelpRequest helpRequest);
        HelpOffer UpdateOffer(HelpOffer helpOffer);

        Task<bool> CommitAsync();

    }
}
