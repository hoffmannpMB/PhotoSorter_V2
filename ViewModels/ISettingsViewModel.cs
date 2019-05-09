using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ViewModels
{
    public interface ISettingsViewModel
    {
        ICommand SaveCommand { get; }
        ICommand BackCommand { get; }
        ObservableCollection<Language> Languages { get; set; }
        Language SelectedLanguage { get; set; }
    }
}