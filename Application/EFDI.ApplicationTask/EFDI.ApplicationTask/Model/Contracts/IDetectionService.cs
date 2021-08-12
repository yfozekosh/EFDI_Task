namespace EFDI.ApplicationTask.Model.Contracts
{
    public interface IDetectionService
    {
        /// <summary>
        ///     Detects device and device data from user agent.
        /// </summary>
        /// <param name="userAgent">User agent from request.</param>
        /// <returns>Detection result with detected data.</returns>
        public DetectionResult Detect(string userAgent);
    }
}