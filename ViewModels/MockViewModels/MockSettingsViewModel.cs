using System.Windows.Input;

namespace ViewModels.MockViewModels
{
    public class MockSettingsViewModel : ISettingsViewModel
    {
        public IAppSettingsViewModel AppSettings { get; }
        public IProjectSettingsViewModel ProjectSettings { get; }
        public ICommand SaveCommand { get; }
        public ICommand BackCommand { get; }
    }
}