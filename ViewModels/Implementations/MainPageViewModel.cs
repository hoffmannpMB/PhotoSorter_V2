using Models;
using Models.Implementations;
using MVVM_Base;
using MVVM_Base.Implementations;
using MVVM_Base.Messenger;
using System.Windows.Input;

namespace ViewModels.Implementations
{
    /// <inheritdoc cref="ViewModelBase" />
    public class MainPageViewModel : ViewModelBase<MainPageModel>, IMainPageViewModel
    {
        private readonly INavigationService _navigationService;
        private readonly IMessenger _messenger;

        public MainPageViewModel(INavigationService navigationService, IMessenger messenger)
        {
            _navigationService = navigationService;
            _messenger = messenger;

            SettingsCommand = new RelayCommand(p => navigationService.NavigateTo("SettingsPage"));
            EditCommand = new RelayCommand(p => ExecuteEdit());
            ToggleShowRedundantPhotosCommand = new RelayCommand(p => IsPaneOpen = !IsPaneOpen);

            Images = new RangeObservableCollection<IPhotoModel>
            {
                new PhotoModel { ImagePath = @"TestImages/leopard1.jpg", RedundantPhotos =
                {
                    new PhotoModel { ImagePath = "ms-appx:///Assets/leopard1.jpg" },
                    new PhotoModel { ImagePath = "ms-appx:///Assets/leopard1.jpg" },
                    new PhotoModel { ImagePath = "ms-appx:///Assets/leopard1.jpg" },
                    new PhotoModel { ImagePath = "ms-appx:///Assets/leopard1.jpg" },
                    new PhotoModel { ImagePath = "ms-appx:///Assets/leopard1.jpg" },
                    new PhotoModel { ImagePath = "ms-appx:///Assets/leopard1.jpg" },
                    new PhotoModel { ImagePath = "ms-appx:///Assets/leopard1.jpg" },
                    new PhotoModel { ImagePath = "ms-appx:///Assets/leopard1.jpg" }
                }},
                new PhotoModel { ImagePath =  "ms-appx:///Assets/leopard2.jpg" },
                new PhotoModel { ImagePath =  "ms-appx:///Assets/leopard1.jpg" },
                new PhotoModel { ImagePath =  "ms-appx:///Assets/leopard2.jpg" },
                new PhotoModel { ImagePath =  "ms-appx:///Assets/leopard2.jpg" }
            };
        }

        public ICommand SettingsCommand { get; }
        public ICommand SaveCommand { get; }
        public ICommand ImportCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand ToggleShowRedundantPhotosCommand { get; }

        private void ExecuteEdit()
        {
            _navigationService.NavigateTo("EditPage");
            _messenger.Send(SelectedPhoto, nameof(SelectedPhoto));
        }

        public bool IsPaneOpen
        {
            get => Model.IsPaneOpen;
            set
            {
                if (value == Model.IsPaneOpen) return;

                Model.IsPaneOpen = value;
                OnPropertyChanged();
            }
        }

        public IPhotoModel SelectedPhoto
        {
            get => Model.SelectedPhoto;
            set
            {
                if (value == Model.SelectedPhoto) return;

                Model.SelectedPhoto = value;
                OnPropertyChanged();
            }
        }

        public IObservableCollection<IPhotoModel> Images { get; }
    }
}