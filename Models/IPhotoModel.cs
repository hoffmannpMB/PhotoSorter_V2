using System;
using MVVM_Base;

namespace Models
{
    public interface IPhotoModel
    {
        string ImagePath { get; set; }
        ICameraModel CameraModel { get; set; }
        DateTime PhotoTaken { get; set; }
        string Description { get; set; }
        IObservableCollection<IPhotoModel> RedundantPhotos { get; }
    }
}