using System;
using System.Windows.Input;
using Models;
using MVVM_Base;

namespace ViewModels.MockViewModels
{
    public class MockPhotoViewModel : IPhotoViewModel
    {
        public ICommand DeleteCommand { get; }
        public ICommand BackCommand { get; }
        public string ImagePath { get; set; }
        public ICameraModel CameraModel { get; set; }
        public DateTime PhotoTaken { get; set; }
        public string Description { get; set; }
        public float Similarity { get; set; }
        public IObservableCollection<IRedundantPhotoModel> RedundantPhotos { get; }
    }
}