using System;

namespace Models.Implementations
{
    public class PhotoModel : IPhotoModel
    {
        public string Path { get; set; }
        public ICameraModel CameraModel { get; set; }
        public DateTime PhotoTaken { get; set; }
        public string Description { get; set; }
    }
}
