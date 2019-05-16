using System;
using System.Collections.Generic;

namespace ViewModels.MockViewModels
{
    public class MockCameraViewModel : ICameraViewModel
    {
        public string Manufacturer { get; set; }
        public string CameraType { get; set; }
        public string IconPath { get; set; }
        public TimeZoneInfo TimeZone { get; set; }
        public string Header { get; }
        public IReadOnlyCollection<TimeZoneInfo> TimeZones { get; }
    }
}