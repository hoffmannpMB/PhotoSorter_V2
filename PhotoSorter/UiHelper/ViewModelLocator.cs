using Windows.ApplicationModel;
using Autofac;
using ViewModels;
using ViewModels.MockViewModels;

namespace PhotoSorter.UiHelper
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

        public IAppSettingsViewModel AppSettingsViewModel => IsInDesignMode
            ? new MockAppSettingsViewModel()
            : _container.Resolve<IAppSettingsViewModel>();

        public IProjectSettingsViewModel ProjectSettingsViewModel => IsInDesignMode
            ? new MockProjectSettingsViewModel()
            : _container.Resolve<IProjectSettingsViewModel>();

        public ISettingsViewModel SettingsViewModel => IsInDesignMode
            ? new MockSettingsViewModel()
            : _container.Resolve<ISettingsViewModel>();

        public IPhotoViewModel PhotoViewModel => IsInDesignMode
            ? new MockPhotoViewModel()
            : _container.Resolve<IPhotoViewModel>();


        // returns true if editing .xaml file in VS for example
        private static bool IsInDesignMode => DesignMode.DesignModeEnabled;
    }
}