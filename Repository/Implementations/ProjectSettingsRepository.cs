using Models;

namespace Repository.Implementations
{
    public class ProjectSettingsRepository : IProjectSettingsRepository
    {
        public T ReadSettings<T>(string key, T defaultValue = default)
        {
            return default;
        }

        public void Save(IProjectSettingsModel appSettings)
        {
        }
    }
}