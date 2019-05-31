using MVVM_Base;

namespace Models
{
    public interface IMainPageModel
    {
        bool ShowRedundantPhotos { get; set; }
        bool ShowDetailsPane { get; }
        bool ShowDetails { get; set; }
        bool ShowDescription { get; set; }
        IPhotoModel SelectedPhoto { get; }

        IObservableCollection<IPhotoModel> Images { get; }
    }
}