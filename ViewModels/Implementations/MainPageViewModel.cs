using System.Collections.ObjectModel;
using System.Windows.Input;
using MVVM_Base;

namespace ViewModels.Implementations
{
    /// <inheritdoc cref="ViewModelBase" />
    public class MainPageViewModel : ViewModelBase, IMainPageViewModel
    {
        public MainPageViewModel(INavigationService navigationService)
        {
            SettingsCommand = new RelayCommand(p => navigationService.NavigateTo("SettingsPage"));
        }

        public ICommand SettingsCommand { get; }

        public ObservableCollection<string> Images { get; set; }
    }
}