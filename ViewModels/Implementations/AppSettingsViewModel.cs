using Models.Implementations;
using MVVM_Base;
using MVVM_Base.Implementations;
using System.Linq;
using Windows.Globalization;
using Language = Models.Implementations.Language;

namespace ViewModels.Implementations
{
    public class AppSettingsViewModel : ViewModelBase<AppSettingsModel>, IAppSettingsViewModel
    {
        public AppSettingsViewModel()
        {
            Languages = new AdvancedObservableCollection<Language>
            {
                new Language { DisplayName = "Deutsch", LanguageCode = "de-DE"},
                new Language { DisplayName = "English", LanguageCode = "en-US"}
            };

            SelectedLanguage =
                Languages.FirstOrDefault(l => l.LanguageCode == ApplicationLanguages.PrimaryLanguageOverride) ?? Languages.First();
        }

        public IObservableCollection<Language> Languages { get; set; }

        public Language SelectedLanguage
        {
            get => Model.SelectedLanguage;
            set
            {
                if (Model.SelectedLanguage == value)
                    return;

                Model.SelectedLanguage = value;
                OnPropertyChanged();
            }
        }
    }
}