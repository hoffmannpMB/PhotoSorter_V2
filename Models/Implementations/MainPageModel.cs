namespace Models.Implementations
{
    public class MainPageModel : IMainPageModel
    {
        public IPhotoModel SelectedPhoto { get; set; }
        public bool IsPaneOpen { get; set; }
    }
}