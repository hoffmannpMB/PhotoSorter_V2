using System;

namespace Models
{
    public interface ICameraModel
    {
        string Manufacturer { get; set; }
        string CameraType { get; set; }
        string IconPath { get; set; }
        TimeZoneInfo TimeZone{ get; set; }
    }
}