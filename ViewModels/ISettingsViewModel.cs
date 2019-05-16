using System.Windows.Input;
using Models;

namespace ViewModels
{
    public interface ISettingsViewModel
    {
        IAppSettingsViewModel AppSettings { get; }
        IProjectSettingsViewModel ProjectSettings { get; }
        ICommand SaveCommand { get; }
        ICommand BackCommand { get; }
    }
}