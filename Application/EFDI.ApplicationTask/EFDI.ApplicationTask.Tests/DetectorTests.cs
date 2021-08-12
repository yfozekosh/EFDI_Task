using EFDI.ApplicationTask.Common.Exceptions;
using EFDI.ApplicationTask.Model;
using EFDI.ApplicationTask.Model.Contracts;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace EFDI.ApplicationTask.Tests
{
    public class DetectorTests : ModuleTestBase
    {
        private readonly IDetectionService _detector;

        public DetectorTests()
        {
            _detector = BuildServices(m => m.AddDeviceDetection())
                .GetRequiredService<IDetectionService>();
        }

        [Fact]
        public void ExceptionWhenNoUserAgent()
        {
            var ex = Assert.Throws<DetectionException>(() => _detector.Detect(string.Empty));

            Assert.Null(ex.InnerException);
        }

        [Theory]
        [InlineData(UserAgent.ChromeWindows, "desktop", "Windows")]
        [InlineData(UserAgent.SafariIpad, "tablet", "iOS")]
        [InlineData(UserAgent.SafariIphone, "smartphone", "iOS")]
        public void UserAgentChrome_WindowsAndBrowser(string ua, string device, string os)
        {
            var result = _detector.Detect(ua);

            Assert.Equal(os, result.OperatingSystem);
            Assert.Equal(device, result.Device);
        }
    }
}