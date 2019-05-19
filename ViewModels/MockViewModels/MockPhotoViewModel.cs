using System;
using Models;
using MVVM_Base;

namespace ViewModels.MockViewModels
{
    public class MockPhotoViewModel : IPhotoViewModel
    {
        public string ImagePath { get; set; }
        public ICameraModel CameraModel { get; set; }
        public DateTime PhotoTaken { get; set; }
        public string Description { get; set; }
        public IObservableCollection<IPhotoModel> RedundantPhotos { get; }
    }
}