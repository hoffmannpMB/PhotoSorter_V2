using MVVM_Base;
using System;

namespace Models
{
    public interface IPhotoModel
    {
        string ImageName { get; set; }
        string ImagePath { get; set; }
        ICameraModel CameraModel { get; set; }
        DateTime DateTaken { get; set; }
        string Description { get; set; }
        bool IsPaneOpen { get; set; }
        IObservableCollection<IRedundantPhotoModel> RedundantPhotos { get; }
    }
}