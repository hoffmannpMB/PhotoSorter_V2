using Windows.Globalization;
using Windows.Storage;
using Models;

namespace Repository.Implementations
{
    public class AppSettingsRepository : IAppSettingsRepository
    {
        private readonly ApplicationDataContainer _localSettings;

        public AppSettingsRepository()
        {
            _localSettings = ApplicationData.Current.LocalSettings;
        }

        public T ReadSettings<T>(string key, T defaultValue = default)
        {
            if (_localSettings.Values.ContainsKey(key))
                return (T)_localSettings.Values[key];

            if (null != defaultValue)
                return defaultValue;

            return default;
        }

        public void Save(IAppSettingsModel appSettings)
        {
            ApplicationLanguages.PrimaryLanguageOverride = appSettings.SelectedLanguage.LanguageCode;
        }
    }
}