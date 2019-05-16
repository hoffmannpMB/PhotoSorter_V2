using Models;
using Repository;

namespace BusinessLogic.Implementations
{
    public class ProjectSettingsService : IProjectSettingsService
    {
        private readonly IProjectSettingsRepository _projectSettingsRepository;

        public ProjectSettingsService(IProjectSettingsRepository projectSettingsRepository)
        {
            _projectSettingsRepository = projectSettingsRepository;
        }

        public T ReadSettings<T>(string key, T defaultValue = default)
        {
            throw new System.NotImplementedException();
        }

        public void Save(IProjectSettingsModel appSettings)
        {
            _projectSettingsRepository.Save(appSettings);
        }
    }
}