using System;
using System.Collections.Generic;
using Models;

namespace ViewModels
{
    public interface ICameraViewModel : ICameraModel
    {
        string Header { get; }
        IReadOnlyCollection<TimeZoneInfo> TimeZones { get; }
    }
}