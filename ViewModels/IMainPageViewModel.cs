using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ViewModels
{
    public interface IMainPageViewModel
    {
        ICommand SettingsCommand { get; }
        ObservableCollection<string> Images { get; set; }
    }
}