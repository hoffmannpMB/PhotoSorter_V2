using Models;
using Models.Implementations;
using MVVM_Base;

namespace ViewModels
{
    public interface IAppSettingsViewModel : IAppSettingsModel
    {
        IObservableCollection<Language> Languages { get; set; }
    }
}