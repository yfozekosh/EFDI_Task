using System;
using System.Threading.Tasks;
using EFDI.ApiTask.DomainDto;
using Microsoft.AspNetCore.Mvc;

namespace EFDI.ApiTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdvertiserController
    {
        [Route("{advertiserId:int}/campaigns/ads")]
        [HttpGet]
        public Task<AdDto[]> GetAds(int advertiserId)
        {
            throw new NotImplementedException();
        }  
    }
}