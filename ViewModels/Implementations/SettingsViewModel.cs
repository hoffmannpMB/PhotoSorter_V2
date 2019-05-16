using BusinessLogic;
using MVVM_Base;
using System.Windows.Input;

namespace ViewModels.Implementations
{
    public class SettingsViewModel : ISettingsViewModel
    {
        private readonly IAppSettingsService _appSettingsService;
        private readonly IProjectSettingsService _projectSettingsService;

        public SettingsViewModel(INavigationService navigationService, IAppSettingsViewModel appSettings, IProjectSettingsViewModel projectSettings, IAppSettingsService appSettingsService, IProjectSettingsService projectSettingsService)
        {
            _appSettingsService = appSettingsService;
            _projectSettingsService = projectSettingsService;
            AppSettings = appSettings;
            ProjectSettings = projectSettings;

            SaveCommand = new RelayCommand(p => ExecuteSave());
            BackCommand = new RelayCommand(p => navigationService.NavigateBack());
        }



        private void ExecuteSave()
        {
            _appSettingsService.Save(AppSettings);
            _projectSettingsService.Save(ProjectSettings);

            BackCommand.Execute(null);
        }

        public IAppSettingsViewModel AppSettings { get; }
        public IProjectSettingsViewModel ProjectSettings { get; }
        public ICommand SaveCommand { get; }
        public ICommand BackCommand { get; }
    }
}