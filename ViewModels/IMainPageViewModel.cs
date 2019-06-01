using Models;
using System.Windows.Input;

namespace ViewModels
{
    public interface IMainPageViewModel : IMainPageModel
    {
        ICommand SettingsCommand { get; }
        ICommand SaveCommand { get; }
        ICommand ImportCommand { get; }
        ICommand OpenCommand { get; }
        ICommand RotateCommand { get; }
        ICommand DeleteCommand { get; }
        ICommand OrderByCommand { get; }
        ICommand CompareCommand { get; }
    }
}