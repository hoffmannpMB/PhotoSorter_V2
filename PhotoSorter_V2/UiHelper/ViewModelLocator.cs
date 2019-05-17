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

        public IAppSettingsViewModel AppSettingsViewModel => IsInDesignMode
            ? new MockAppSettingsViewModel()
            : _container.Resolve<IAppSettingsViewModel>();

        public IProjectSettingsViewModel ProjectSettingsViewModel => IsInDesignMode
            ? new MockProjectSettingsViewModel()
            : _container.Resolve<IProjectSettingsViewModel>();

        public ISettingsViewModel SettingsViewModel => IsInDesignMode
            ? new MockSettingsViewModel()
            : _container.Resolve<ISettingsViewModel>();

        public object PhotoViewModel => IsInDesignMode
            ? new MockPhotoViewModel()
            : _container.Resolve<IPhotoViewModel>();


        // returns true if editing .xaml file in VS for example
        private static bool IsInDesignMode => DesignMode.DesignModeEnabled;
    }
}