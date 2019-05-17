using System;
using Models;

namespace ViewModels
{
    public interface IPhotoViewModel
    {
        string ImagePath { get; set; }
        ICameraModel CameraModel { get; set; }
        DateTime PhotoTaken { get; set; }
        string Description { get; set; }
    }
}