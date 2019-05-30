using Models;
using Models.Implementations;
using MVVM_Base;
using MVVM_Base.Messenger;
using System;
using System.Windows.Input;

namespace ViewModels.Implementations
{
    public class PhotoViewModel : ViewModelBase<PhotoModel>, IPhotoViewModel
    {
        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationService;

        public PhotoViewModel(IMessenger messenger, INavigationService navigationService)
        {
            _messenger = messenger;
            _navigationService = navigationService;

            messenger.Register<IPhotoModel>(this, "SelectedPhoto", p => Model = (PhotoModel)p);
            BackCommand = new RelayCommand(p => ExecuteBack());
        }

        private void ExecuteBack()
        {
            _messenger.Send(Description, "PhotoDescription");
            _navigationService.NavigateBack();
        }

        public ICommand BackCommand { get; }

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

        public float Similarity
        {
            get => Model.Similarity;
            set
            {
                if (Math.Abs(value - Model.Similarity) < 0.2) return;

                Model.Similarity = value;
                OnPropertyChanged();
            }
        }

        public IObservableCollection<IRedundantPhotoModel> RedundantPhotos => Model.RedundantPhotos;
    }
}