using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFDI.ApplicationTask.Pipeline
{
    public class BadRequestCustomResult : ActionResult
    {
        private readonly string _message;

        public BadRequestCustomResult(string message)
        {
            _message = message;
        }

        public override Task ExecuteResultAsync(ActionContext context)
        {
            context.HttpContext.Response.ContentType = "text/html";
            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            context.HttpContext.Response.WriteAsync(_message);
            
            return Task.CompletedTask;
        }
    }
}