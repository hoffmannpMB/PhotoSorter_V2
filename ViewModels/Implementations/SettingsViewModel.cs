using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Windows.Storage;
using Models;
using MVVM_Base;

namespace ViewModels.Implementations
{
    public class SettingsViewModel : ViewModelBase<SettingsModel>, ISettingsViewModel
    {
        private readonly ApplicationDataContainer _localSettings;

        public SettingsViewModel(INavigationService navigationService)
        {
            _localSettings = ApplicationData.Current.LocalSettings;
            SaveCommand = new RelayCommand(p => ExecuteSave());
            BackCommand = new RelayCommand(p => navigationService.NavigateBack());
            Languages = new ObservableCollection<Language>
            {
                new Language { DisplayName = "Deutsch", LanguageCode = "de-DE"},
                new Language { DisplayName = "English", LanguageCode = "en-US"}
            };

            SelectedLanguage = ReadSettings<Language>(nameof(SelectedLanguage), Languages.First());
        }

        public ICommand SaveCommand { get; }
        public ICommand BackCommand { get; }

        private void ExecuteSave()
        {
            _localSettings.Values[nameof(SelectedLanguage)] = SelectedLanguage;

            BackCommand.Execute(null);
        }

        private T ReadSettings<T>(string key, T defaultValue = default)
        {
            if (_localSettings.Values.ContainsKey(key))
                return (T)_localSettings.Values[key];

            if (null != defaultValue)
                return defaultValue;

            return default;
        }

        public ObservableCollection<Language> Languages { get; set; }

        public Language SelectedLanguage
        {
            get => Model.SelectedLanguage;
            set
            {
                if (Model.SelectedLanguage == value) return;
                
                Model.SelectedLanguage = value;
                OnPropertyChanged();
            }
        }
    }
}