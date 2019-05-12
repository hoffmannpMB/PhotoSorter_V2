namespace Models.Implementations
{
    public class SettingsModel
    {
        public SettingsModel()
        {
            SelectedLanguage = new Language();
        }

        public Language SelectedLanguage { get; set; }
    }
}