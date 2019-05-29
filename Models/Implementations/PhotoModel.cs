using System;
using MVVM_Base;
using MVVM_Base.Implementations;

namespace Models.Implementations
{
    public class PhotoModel : IPhotoModel
    {
        public PhotoModel()
        {
            RedundantPhotos = new AdvancedObservableCollection<IPhotoModel>();
            Similarity = 70;
        }

        public string ImagePath { get; set; }
        public ICameraModel CameraModel { get; set; }
        public DateTime PhotoTaken { get; set; }
        public string Description { get; set; }
        public float Similarity { get; set; }
        public IObservableCollection<IPhotoModel> RedundantPhotos { get; }
    }
}
