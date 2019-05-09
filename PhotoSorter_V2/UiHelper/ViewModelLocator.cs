using Autofac;
using ViewModels;
using ViewModels.MockViewModels;
using Windows.ApplicationModel;

namespace PhotoSorter_V2.UiHelper
{
    public class ViewModelLocator
    {
        private readonly IContainer _container;

        public ViewModelLocator()
        {
            _container = Bootstrapper.Instance.Container;
        }

        public IMainPageViewModel MainPageViewModel => IsInDesignMode
            ? new MockMainPageViewModel()
            : _container.Resolve<IMainPageViewModel>();

        public ISettingsViewModel SettingsViewModel => IsInDesignMode
            ? new MockSettingsViewModel()
            : _container.Resolve<ISettingsViewModel>();



        // returns true if editing .xaml file in VS for example
        private static bool IsInDesignMode => DesignMode.DesignModeEnabled;
    }
}