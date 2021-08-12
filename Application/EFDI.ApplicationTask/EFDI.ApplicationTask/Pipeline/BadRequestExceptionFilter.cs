using EFDI.ApplicationTask.Common;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace EFDI.ApplicationTask.Pipeline
{
    public class BadRequestExceptionFilter : ExceptionFilterAttribute
    {
        private readonly ILogger<BadRequestExceptionFilter> _logger;

        public BadRequestExceptionFilter(ILogger<BadRequestExceptionFilter> logger)
        {
            _logger = logger;
        }

        public override void OnException(ExceptionContext context)
        {
            if (context.Exception is IUserFriendlyException uf)
            {
                _logger.LogInformation($"App exception: {uf.Message}", context.Exception);
                try
                {
                    context.Result = new BadRequestCustomResult(uf.Message);
                }
                catch (System.Exception e)
                {
                    _logger.LogInformation($"exception during user friendly exception handling: {e.Message}", e);
                    // ignored.
                }
            }
            else
            {
#if DEBUG
                _logger.LogError($"Exception on request handling.: {context.Exception.Message}", context.Exception);
                try
                {
                    context.Result = new BadRequestCustomResult(context.Exception.ToString());
                }
                catch (System.Exception e)
                {
                    _logger.LogInformation($"exception: {e.Message}", e);
                    // ignored.
                }
#endif
                base.OnException(context);
            }
        }
    }
}