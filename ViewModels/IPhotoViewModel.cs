using System;
using Models;
using MVVM_Base;

namespace ViewModels
{
    public interface IPhotoViewModel
    {
        string ImagePath { get; set; }
        ICameraModel CameraModel { get; set; }
        DateTime PhotoTaken { get; set; }
        string Description { get; set; }
        IObservableCollection<IPhotoModel> RedundantPhotos { get; }
    }
}