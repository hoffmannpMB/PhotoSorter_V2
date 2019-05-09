using ViewModels.Implementations;

namespace ViewModels.MockViewModels
{
    public class MockSettingsViewModel : SettingsViewModel
    {
        public MockSettingsViewModel() : base(new MockNavigationService())
        {
        }
    }
}