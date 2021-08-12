using System;
using System.Threading.Tasks;
using EFDI.ApiTask.DomainDto;
using Microsoft.AspNetCore.Mvc;

namespace EFDI.ApiTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdController
    {
        [Route("{id:int}")]
        [HttpGet]
        public Task<AdDto> GetAd(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// API endpoint that creates an Ad.
        /// </summary>
        /// <returns>Id of the created Ad.</returns>
        [HttpPost]
        public Task<int> CreateAd([FromBody] AdDto ad)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("{id:int}")]
        public Task UpdateAd([FromRoute] int id, [FromBody] AdEditDto ad)
        {
            throw new NotImplementedException();
        }
    }
}