using MVVM_Base;
using System;

namespace Models
{
    public interface IPhotoModel : IImage
    {
        ICameraModel CameraModel { get; set; }
        DateTimeOffset DateTaken { get; set; }
        string Description { get; set; }
        IRedundantPhotoModel SelectedRedundantPhoto { get; set; }
        IObservableCollection<IRedundantPhotoModel> RedundantPhotos { get; }
    }
}