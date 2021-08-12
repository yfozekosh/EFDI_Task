using System;
using EFDI.ApplicationTask.Model.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EFDI.ApplicationTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DetectController : Controller
    {
        private readonly IDetectionService _detectionService;
        private readonly ILogger<DetectController> _logger;

        public DetectController(IDetectionService detectionService, ILogger<DetectController> logger)
        {
            _detectionService = detectionService;
            _logger = logger;
        }
        
        [HttpGet]
        public IActionResult Detect()
        {
            string userAgent;
            try
            {
                userAgent = Request.Headers["User-Agent"].ToString();
            }
            catch (Exception e)
            {
                _logger.LogError($"Cannot get User-Agent from request. {e.Message}", e);

                return BadRequest("User-Agent is not defined");
            }

            return Ok(_detectionService.Detect(userAgent));
        }
    }
}