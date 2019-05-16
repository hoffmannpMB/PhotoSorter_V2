using Models;
using Repository;

namespace BusinessLogic.Implementations
{
    public class AppSettingsService : IAppSettingsService
    {
        private readonly IAppSettingsRepository _appSettingsRepository;

        public AppSettingsService(IAppSettingsRepository appSettingsRepository)
        {
            _appSettingsRepository = appSettingsRepository;
        }

        public T ReadSettings<T>(string key, T defaultValue = default)
        {
            return _appSettingsRepository.ReadSettings(key, defaultValue);
        }

        public void Save(IAppSettingsModel appSettings)
        {
            _appSettingsRepository.Save(appSettings);
        }
    }
}