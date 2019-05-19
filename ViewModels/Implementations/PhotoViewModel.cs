using System;
using Models;
using Models.Implementations;
using MVVM_Base;
using MVVM_Base.Messenger;

namespace ViewModels.Implementations
{
    public class PhotoViewModel : ViewModelBase<PhotoModel>, IPhotoViewModel
    {
        public PhotoViewModel(IMessenger messenger)
        {
            messenger.Register<IPhotoModel>(this, "SelectedPhoto", T);
        }

        private void T(IPhotoModel obj)
        {
            Model = (PhotoModel) obj;
        }

        public string ImagePath
        {
            get => Model.ImagePath;
            set
            {
                if (value == ImagePath) return;

                Model.ImagePath = value;
                OnPropertyChanged();
            }
        }

        public ICameraModel CameraModel
        {
            get => Model.CameraModel;
            set
            {
                if (value == CameraModel) return;

                Model.CameraModel = value;
                OnPropertyChanged();
            }
        }

        public DateTime PhotoTaken
        {
            get => Model.PhotoTaken;
            set
            {
                if (value == PhotoTaken) return;

                Model.PhotoTaken = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get => Model.Description;
            set
            {
                if (value == Description) return;

                Model.Description = value;
                OnPropertyChanged();
            }
        }

        public IObservableCollection<IPhotoModel> RedundantPhotos => Model.RedundantPhotos;
    }
}