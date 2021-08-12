using System;
using System.Threading.Tasks;
using EFDI.ApiTask.DomainDto;
using Microsoft.AspNetCore.Mvc;

namespace EFDI.ApiTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CampaignController
    {
        [Route("{campaignId:int}/ads")]
        [HttpGet]
        public Task<AdDto[]> GetAds(int campaignId)
        {
            throw new NotImplementedException();
        }
    }
}