namespace Models
{
    public interface IMainPageModel
    {
        bool IsPaneOpen { get; set; }
        IPhotoModel SelectedPhoto { get; set; }
    }
}