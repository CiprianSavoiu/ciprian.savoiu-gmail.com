using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Community.Map.Models;

namespace Community.Map.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICommunityRepository _communityRepository;

        public HomeController(ILogger<HomeController> logger,
            ICommunityRepository communityRepository)
        {
            _logger = logger;
            _communityRepository = communityRepository;
        }

        public async Task<IActionResult> Index()
        {
            var mainHelp = new MainHelp();
            var helpOffers =  await _communityRepository.GetHelpOffersAsync();
            var helpRequests = await _communityRepository.GetRequestsAsync();
            mainHelp.HelpOffers = helpOffers.ToList();
            mainHelp.HelpRequests = helpRequests.ToList();
            return View(mainHelp);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public async Task<bool> SubmitRequest(HelpRequest helpRequest)
        {
            try
            {
                if (helpRequest.Email == null)
                {
                    helpRequest.Email = "no email";
                }
                if (helpRequest.Phone == null)
                {
                    helpRequest.Phone = "no phone";
                }
                _communityRepository.AddRequest(helpRequest);
                await _communityRepository.CommitAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        [HttpPost]
        public async Task<bool> SubmitOffer(HelpOffer helpOffer)
        {
            try
            {
                if (helpOffer.Email == null)
                {
                    helpOffer.Email = "no email";
                }
                if (helpOffer.Phone == null)
                {
                    helpOffer.Phone = "no phone";
                }
                if (helpOffer.WebAddress == null)
                {
                    helpOffer.WebAddress = "n/a";
                }
                _communityRepository.AddOffer(helpOffer);
                await _communityRepository.CommitAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }

    }
}
