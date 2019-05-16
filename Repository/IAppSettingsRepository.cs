using Models;

namespace Repository
{
    public interface IAppSettingsRepository
    {
        T ReadSettings<T>(string key, T defaultValue = default);

        void Save(IAppSettingsModel appSettings);
    }
}