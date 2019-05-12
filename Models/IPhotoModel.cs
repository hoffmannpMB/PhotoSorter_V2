using System;

namespace Models
{
    public interface IPhotoModel
    {
        string Path { get; set; }
        ICameraModel CameraModel { get; set; }
        DateTime PhotoTaken { get; set; }
        string Description { get; set; }
    }
}