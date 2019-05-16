using Models;

namespace BusinessLogic
{
    public interface IAppSettingsService
    {
        T ReadSettings<T>(string key, T defaultValue = default);

        void Save(IAppSettingsModel appSettings);
    }
}