using Models;
using MVVM_Base;
using MVVM_Base.Implementations;
using System;

namespace ViewModels.Implementations
{
    public class ProjectSettingsViewModel : ViewModelBase, IProjectSettingsViewModel
    {
        public ProjectSettingsViewModel()
        {

            CameraModels = new AdvancedObservableCollection<ICameraModel>
            {
                new CameraViewModel
                {
                    CameraType = "Camera 1", IconPath = new Uri("ms-appx:///Assets/leopard1.jpg").LocalPath, Manufacturer = "Test",
                    TimeZone = TimeZoneInfo.Local
                },
                new CameraViewModel
                {
                    CameraType = "Camera 2", IconPath = new Uri("ms-appx:///Assets/leopard1.jpg").AbsolutePath, Manufacturer = "Test",
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