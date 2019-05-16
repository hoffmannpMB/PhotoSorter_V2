using System;
using System.Collections.ObjectModel;
using MVVM_Base;

namespace ViewModels.Implementations
{
    public class ProjectSettingsViewModel : ViewModelBase, IProjectSettingsViewModel
    {
        public ProjectSettingsViewModel()
        {

            CameraViewModels = new ObservableCollection<ICameraViewModel>
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

        public ObservableCollection<ICameraViewModel> CameraViewModels { get; }
    }
}