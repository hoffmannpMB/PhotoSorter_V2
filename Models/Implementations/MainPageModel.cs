using MVVM_Base;
using MVVM_Base.Implementations;
using System;

namespace Models.Implementations
{
    public class MainPageModel : IMainPageModel
    {
        public MainPageModel()
        {
            Images = new AdvancedObservableCollection<IPhotoModel>
            {
                new PhotoModel
                {
                    ImagePath = @"ms-appx:///Assets/leopard1.jpg", Description =
                        @"{\rtf1\fbidis\ansi\ansicpg1252\deff0\nouicompat\deflang1031{\fonttbl{\f0\fnil Segoe UI;}{\f1\fnil\fcharset0 Segoe UI;}}
                                                                                                {\colortbl ;\red255\green255\blue255;}
                                                                                                {\*\generator Riched20 10.0.17763}\viewkind4\uc1 
                                                                                                \pard\tx720\cf1\f0\fs21 Hallo Welt\f1\fs20  Anders \i Italic \fs40 Gro\'df\i0\f0\fs20\par
                                                                                                }",
                    RedundantPhotos =
                    {
                        new RedundantPhotoModel {ImagePath = "ms-appx:///Assets/leopard2.jpg", Similarity = 70},
                        new RedundantPhotoModel {ImagePath = "ms-appx:///Assets/leopard1.jpg", Similarity = 20},
                        new RedundantPhotoModel {ImagePath = "ms-appx:///Assets/leopard1.jpg", Similarity = 40},
                        new RedundantPhotoModel {ImagePath = "ms-appx:///Assets/leopard1.jpg", Similarity = 80},
                        new RedundantPhotoModel {ImagePath = "ms-appx:///Assets/leopard1.jpg", Similarity = 10},
                        new RedundantPhotoModel {ImagePath = "ms-appx:///Assets/leopard1.jpg", Similarity = 30},
                        new RedundantPhotoModel {ImagePath = "ms-appx:///Assets/leopard1.jpg", Similarity = 50},
                        new RedundantPhotoModel {ImagePath = "ms-appx:///Assets/leopard1.jpg", Similarity = 90}
                    },
                    DateTaken = DateTimeOffset.Now
                },
                new PhotoModel {ImagePath = "/Assets/leopard2.jpg", Description = "Hallo Welt"},
                new PhotoModel
                {
                    ImagePath = "ms-appx:///Assets/leopard1.jpg", DateTaken = DateTimeOffset.Now,
                    CameraModel = new CameraModel {Manufacturer = "Canon", CameraType = "IP2980"}
                },
                new PhotoModel {ImagePath = "ms-appx:///Assets/leopard2.jpg", DateTaken = DateTimeOffset.MinValue },
                new PhotoModel {ImagePath = "ms-appx:///Assets/leopard2.jpg", DateTaken = DateTimeOffset.MaxValue }
            };
        }

        public bool ShowDescription { get; set; }
        public IPhotoModel SelectedPhoto { get; set; }
        public IObservableCollection<IPhotoModel> Images { get; }
        public bool ShowRedundantPhotos { get; set; }
        public bool ShowDetails { get; set; }
        public bool ShowDetailsPane => (ShowDescription && !string.IsNullOrWhiteSpace(SelectedPhoto.Description)) | ShowDetails;
    }
}