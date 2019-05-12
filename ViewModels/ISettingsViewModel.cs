using System.Collections.ObjectModel;
using System.Windows.Input;
using Models.Implementations;

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