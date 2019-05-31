using System;
using System.IO;
using MVVM_Base;
using MVVM_Base.Implementations;

namespace Models.Implementations
{
    public class PhotoModel : IPhotoModel
    {
        public PhotoModel()
        {
            RedundantPhotos = new AdvancedObservableCollection<IRedundantPhotoModel>();
            ImageName = Path.GetFileName(ImagePath);
        }

        public string ImageName { get; set; }
        public string ImagePath { get; set; }
        public ICameraModel CameraModel { get; set; }
        public DateTime DateTaken { get; set; }
        public string Description { get; set; }
        public IObservableCollection<IRedundantPhotoModel> RedundantPhotos { get; }
    }
}
