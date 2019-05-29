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

            messenger.Register<string>(this, "PhotoDescription", p => { SelectedPhoto.Description = p; });

            SettingsCommand = new RelayCommand(p => navigationService.NavigateTo("SettingsPage"));
            EditCommand = new RelayCommand(p => ExecuteEdit());
            ToggleShowRedundantPhotosCommand = new RelayCommand(p => IsPaneOpen = !IsPaneOpen);
            SaveCommand = new RelayCommand(p => ExecuteSave());
            ImportCommand = new RelayCommand(p => ExecuteImport());

            Images = new AdvancedObservableCollection<IPhotoModel>
            {
                new PhotoModel { ImagePath = @"ms-appx:///Assets/leopard1.jpg", Description = @"{\rtf1\fbidis\ansi\ansicpg1252\deff0\nouicompat\deflang1031{\fonttbl{\f0\fnil Segoe UI;}{\f1\fnil\fcharset0 Segoe UI;}}
                                                                                                {\colortbl ;\red255\green255\blue255;}
                                                                                                {\*\generator Riched20 10.0.17763}\viewkind4\uc1 
                                                                                                \pard\tx720\cf1\f0\fs21 Hallo Welt\f1\fs20  Anders \i Italic \fs40 Gro\'df\i0\f0\fs20\par
                                                                                                }",
                    RedundantPhotos =
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

        private void ExecuteImport()
        {
            // import photos
            // convert PhotoModels into PhotoViewModels
        }

        private void ExecuteSave()
        {
            // copy photos to project location
            // create/edit xml
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