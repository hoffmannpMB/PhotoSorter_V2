using Models;

namespace BusinessLogic
{
    public interface IProjectSettingsService
    {
        T ReadSettings<T>(string key, T defaultValue = default);

        void Save(IProjectSettingsModel appSettings);
    }
}