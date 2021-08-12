using System;
using DeviceDetectorNET;
using EFDI.ApplicationTask.Common.Exceptions;
using EFDI.ApplicationTask.Model.Contracts;
using Microsoft.Extensions.Logging;

namespace EFDI.ApplicationTask.Model
{
    internal class DetectionService : IDetectionService
    {
        private readonly ILogger<DetectionService> _logger;

        public DetectionService(ILogger<DetectionService> logger)
        {
            _logger = logger;
        }

        public DetectionResult Detect(string userAgent)
        {
            if (string.IsNullOrWhiteSpace(userAgent))
                throw new DetectionException("Cannot detect device, because no information is provided.");

            DetectionResult result;

            try
            {
                _logger.LogDebug($"Starting detection of \"{userAgent}\"");
                DeviceDetector detector = new(userAgent);
                detector.Parse();

                var osInfo = detector.GetOs();

                result = new DetectionResult(
                    detector.GetDeviceName(),
                    osInfo.Success ? osInfo.Match.Name : "undefined"
                );
            }
            catch (Exception e)
            {
                throw new DetectionException("Detection failed", e);
            }

            return result;
        }
    }
}