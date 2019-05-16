using Models;

namespace Repository
{
    public interface IProjectSettingsRepository
    {
        T ReadSettings<T>(string key, T defaultValue = default);

        void Save(IProjectSettingsModel appSettings);
    }
}