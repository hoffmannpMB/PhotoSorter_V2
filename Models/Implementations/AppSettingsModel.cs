namespace Models.Implementations
{
    public class AppSettingsModel : IAppSettingsModel
    {
        public AppSettingsModel()
        {
            SelectedLanguage = new Language();
        }

        public Language SelectedLanguage { get; set; }
    }
}