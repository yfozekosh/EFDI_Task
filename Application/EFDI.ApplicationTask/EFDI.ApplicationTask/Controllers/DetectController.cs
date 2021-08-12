using System;
using EFDI.ApplicationTask.Model.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace EFDI.ApplicationTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DetectController
    {
        private readonly IDetectionService _detectionService;

        public DetectController(IDetectionService detectionService)
        {
            _detectionService = detectionService;
        }
        
        [HttpGet]
        public void Detect()
        {
            throw new NotImplementedException();
        }
    }
}