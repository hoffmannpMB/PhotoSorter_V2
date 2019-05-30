using System.Windows.Input;

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