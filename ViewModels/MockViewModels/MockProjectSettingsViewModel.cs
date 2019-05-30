using MVVM_Base;
using MVVM_Base.Implementations;
using System;
using Models;
using ViewModels.Implementations;

namespace ViewModels.MockViewModels
{
    public class MockProjectSettingsViewModel : IProjectSettingsViewModel
    {
        public MockProjectSettingsViewModel()
        {
            CameraModels = new AdvancedObservableCollection<ICameraModel>
            {
                new CameraViewModel
                {
                    CameraType = "Camera 1", IconPath = @"TestImages/leopard1.jpg", Manufacturer = "Test",
                    TimeZone = TimeZoneInfo.Local
                },
                new CameraViewModel
                {
                    CameraType = "Camera 2", IconPath = @"TestImages/leopard1.jpg", Manufacturer = "Test",
                    TimeZone = TimeZoneInfo.Local
                },
                new CameraViewModel
                {
                    CameraType = "Camera 3", IconPath = @"TestImages/leopard1.jpg", Manufacturer = "Test",
                    TimeZone = TimeZoneInfo.Local
                },
                new CameraViewModel
                {
                    CameraType = "Camera 4", IconPath = @"TestImages/leopard1.jpg", Manufacturer = "Test",
                    TimeZone = TimeZoneInfo.Local
                },
                new CameraViewModel
                {
                    CameraType = "Camera 5", IconPath = @"TestImages/leopard1.jpg", Manufacturer = "Test",
                    TimeZone = TimeZoneInfo.Local
                },
                new CameraViewModel
                {
                    CameraType = "Camera 6", IconPath = @"TestImages/leopard1.jpg", Manufacturer = "Test",
                    TimeZone = TimeZoneInfo.Local
                }
            };
        }

        public IObservableCollection<ICameraModel> CameraModels { get; }
    }
}