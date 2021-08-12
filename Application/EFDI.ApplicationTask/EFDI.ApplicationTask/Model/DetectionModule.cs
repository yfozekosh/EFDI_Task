using EFDI.ApplicationTask.Model.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace EFDI.ApplicationTask.Model
{
    public static class DetectionModule
    {
        public static IServiceCollection AddDeviceDetection(this IServiceCollection services)
        {
            services.AddTransient<IDetectionService, DetectionService>();

            return services;
        }
    }
}