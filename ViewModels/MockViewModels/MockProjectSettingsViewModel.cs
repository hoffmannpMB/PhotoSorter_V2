using System;
using System.Collections.ObjectModel;
using ViewModels.Implementations;

namespace ViewModels.MockViewModels
{
    public class MockProjectSettingsViewModel : IProjectSettingsViewModel
    {
        public MockProjectSettingsViewModel()
        {
            CameraViewModels = new ObservableCollection<ICameraViewModel>
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

        public ObservableCollection<ICameraViewModel> CameraViewModels { get; }
    }
}