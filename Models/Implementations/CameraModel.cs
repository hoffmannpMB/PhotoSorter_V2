using System;

namespace Models.Implementations
{
    public class CameraModel : ICameraModel
    {
        public CameraModel()
        {
            TimeZone = TimeZoneInfo.Local;
        }

        public string CameraType { get; set; }
        public string IconPath { get; set; }
        public TimeZoneInfo TimeZone { get; set; }
        public string Manufacturer { get; set; }

        public override string ToString()
        {
            return $"{Manufacturer} {CameraType}";
        }
    }
}