using Models.Implementations;

namespace Models
{
    public interface IAppSettingsModel
    {
        Language SelectedLanguage { get; set; }
    }
}