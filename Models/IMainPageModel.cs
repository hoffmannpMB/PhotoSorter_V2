namespace Models.Implementations
{
    public interface IMainPageModel
    {
        bool IsPaneOpen { get; set; }
        IPhotoModel SelectedPhoto { get; set; }
    }
}