namespace EFDI.ApplicationTask.Model.Contracts
{
    public class DetectionResult
    {
        public DetectionResult(string device, string operatingSystem)
        {
            Device = device;
            OperatingSystem = operatingSystem;
        }

        public string Device { get; }

        public string OperatingSystem { get; }
    }
}