using Models;
using MVVM_Base;
using System;
using System.Windows.Input;

namespace ViewModels
{
    public interface IPhotoViewModel
    {
        ICommand BackCommand { get; }
        string ImagePath { get; set; }
        ICameraModel CameraModel { get; set; }
        DateTime PhotoTaken { get; set; }
        string Description { get; set; }
        IObservableCollection<IPhotoModel> RedundantPhotos { get; }
    }
}