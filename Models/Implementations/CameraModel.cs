using System;

namespace Models.Implementations
{
    public class CameraModel : ICameraModel
    {
        public string CameraType { get; set; }
        public string IconPath { get; set; }
        public TimeZoneInfo TimeZone { get; set; }
        public string Manufacturer { get; set; }
    }
}