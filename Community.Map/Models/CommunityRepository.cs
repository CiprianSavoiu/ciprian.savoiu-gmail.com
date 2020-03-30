using Community.Map.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community.Map.Models
{
    public class CommunityRepository : ICommunityRepository
    {

        private readonly ApplicationDbContext appDbContext;

        public CommunityRepository(ApplicationDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<IEnumerable<HelpRequest>> GetRequestsAsync()
        {
            return await appDbContext.HelpRequests.ToListAsync();
        }

        public async Task<IEnumerable<HelpOffer>> GetHelpOffersAsync()
        {
            return await appDbContext.HelpOffers.ToListAsync();
        }

        public HelpRequest GetRequest(int requestId)
        {
            throw new NotImplementedException();
        }

        public HelpOffer GetOffer(int offerId)
        {
            throw new NotImplementedException();
        }

        public HelpRequest AddRequest(HelpRequest helpRequest)
        {
            if (helpRequest == null) return helpRequest;
            appDbContext.HelpRequests.Add(helpRequest);
            return helpRequest;
        }

        public HelpOffer AddOffer(HelpOffer helpOffer)
        {
            if (helpOffer == null) return helpOffer;
            appDbContext.HelpOffers.Add(helpOffer);
            return helpOffer;
        }

        public HelpRequest DeleteRequest(int requestId)
        {
            throw new NotImplementedException();
        }

        public HelpOffer DeleteOffer(int offerId)
        {
            throw new NotImplementedException();
        }

        public HelpRequest UpdateRequest(HelpRequest helpRequest)
        {
            throw new NotImplementedException();
        }

        public HelpOffer UpdateOffer(HelpOffer helpOffer)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> CommitAsync()
        {
            try
            {
                return await appDbContext.SaveChangesAsync() == 1;
            }
            catch (Exception e)
            {
                return false;
            }
           
        }
    }
}
