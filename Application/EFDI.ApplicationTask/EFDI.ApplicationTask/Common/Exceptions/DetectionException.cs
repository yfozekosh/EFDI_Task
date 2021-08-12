using System;

namespace EFDI.ApplicationTask.Common.Exceptions
{
    public class DetectionException : Exception, IUserFriendlyException
    {
        public DetectionException(string message) : base(message)
        {
        }

        public DetectionException(string? message, Exception innerException) : base(message, innerException)
        {
        }
    }
}