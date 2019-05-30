using Models;
using System.Windows.Input;

namespace ViewModels
{
    public interface IMainPageViewModel : IMainPageModel
    {
        ICommand SettingsCommand { get; }
        ICommand SaveCommand { get; }
        ICommand ImportCommand { get; }
        ICommand EditCommand { get; }
        ICommand ToggleShowRedundantPhotosCommand { get; }
    }
}