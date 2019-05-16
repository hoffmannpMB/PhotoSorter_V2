using System.Windows.Input;
using ViewModels.Implementations;

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