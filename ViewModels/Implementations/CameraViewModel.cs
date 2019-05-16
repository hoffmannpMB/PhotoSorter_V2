using System;
using System.Collections.Generic;
using Models.Implementations;
using MVVM_Base;

namespace ViewModels.Implementations
{
    public class CameraViewModel : ViewModelBase<CameraModel>, ICameraViewModel
    {
        public string Manufacturer { get; set; }
        public string CameraType { get; set; }
        public string IconPath { get; set; }
        public TimeZoneInfo TimeZone { get; set; }
        public string Header => $"{Manufacturer} {CameraType}";
        public IReadOnlyCollection<TimeZoneInfo> TimeZones => TimeZoneInfo.GetSystemTimeZones();
    }
}