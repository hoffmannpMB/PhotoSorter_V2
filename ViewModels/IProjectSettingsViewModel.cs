using Models;
using MVVM_Base;

namespace ViewModels
{
    public interface IProjectSettingsViewModel : IProjectSettingsModel
    {
        IObservableCollection<ICameraModel> CameraModels { get; }
    }
}