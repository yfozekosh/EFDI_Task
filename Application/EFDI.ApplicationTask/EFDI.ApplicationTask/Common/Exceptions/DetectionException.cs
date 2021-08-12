using System;

namespace EFDI.ApplicationTask.Common.Exceptions
{
    public class DetectionException : Exception, IUserFriendlyException
    {
        public DetectionException()
        {
        }

        public DetectionException(string? message) : base(message)
        {
        }
    }
}