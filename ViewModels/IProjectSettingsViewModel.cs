using System.Collections.ObjectModel;
using Models;

namespace ViewModels
{
    public interface IProjectSettingsViewModel : IProjectSettingsModel
    {
        ObservableCollection<ICameraViewModel> CameraViewModels { get; }
    }
}