using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace EFDI.ApplicationTask.Tests.Integration
{
    public class DetectorControllerTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private HttpClient _client;

        public DetectorControllerTests(WebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task UserAgentIsParsedFromHeaders()
        {
            _client.DefaultRequestHeaders.Add("User-Agent", UserAgent.ChromeWindows);
            
            // Act
            var response = await _client.GetAsync("Detect");

            // Assert
            response.EnsureSuccessStatusCode();
        }
    }
}