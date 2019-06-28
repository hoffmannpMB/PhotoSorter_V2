using MVVM_Base;
using MVVM_Base.Implementations;
using System;
using System.IO;

namespace Models.Implementations
{
    public class PhotoModel : IPhotoModel
    {
        public PhotoModel()
        {
            Description = string.Empty;
            ImageName = Path.GetFileName(ImagePath);
            RedundantPhotos = new AdvancedObservableCollection<IRedundantPhotoModel>();
        }

        public string ImageName { get; set; }
        public string ImagePath { get; set; }
        public string TmpImagePath { get; set; }
        public float Rotation { get; set; }
        public ICameraModel CameraModel { get; set; }
        public DateTimeOffset DateTaken { get; set; }
        public string Description { get; set; }
        public IRedundantPhotoModel SelectedRedundantPhoto { get; set; }
        public IObservableCollection<IRedundantPhotoModel> RedundantPhotos { get; }
    }
}
