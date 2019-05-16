using Models.Implementations;
using System.Collections.ObjectModel;
using Models;

namespace ViewModels
{
    public interface IAppSettingsViewModel : IAppSettingsModel
    {
        ObservableCollection<Language> Languages { get; set; }
    }
}