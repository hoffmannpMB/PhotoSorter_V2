using System.Linq;
using Models;
using Models.Implementations;
using MVVM_Base;
using MVVM_Base.Messenger;
using System.Windows.Input;

namespace ViewModels.Implementations
{
    /// <inheritdoc cref="ViewModelBase" />
    public class MainPageViewModel : ViewModelBase<MainPageModel>, IMainPageViewModel
    {
        private readonly INavigationService _navigationService;
        private readonly IMessenger _messenger;

        public MainPageViewModel(INavigationService navigationService, IMessenger messenger, IViewModelFactory factory)
        {
            _navigationService = navigationService;
            _messenger = messenger;

            messenger.Register<string>(this, "PhotoDescription", p => { SelectedPhoto.Description = p; });
            Model.Images.Cast(factory.Create);

            SettingsCommand = new RelayCommand(p => navigationService.NavigateTo("SettingsPage"));
            EditCommand = new RelayCommand(p => ExecuteEdit());
            SaveCommand = new RelayCommand(p => ExecuteSave());
            ImportCommand = new RelayCommand(p => ExecuteImport());
            OpenCommand = new RelayCommand(p => ExecuteOpen());
            RotateCommand = new RelayCommand(p => ExecuteRotate());
            DeleteCommand = new RelayCommand(p => ExecuteDelete());
            OrderByCommand = new RelayCommand(p => ExecuteOrderBy());
            CompareCommand = new RelayCommand(p => ExecuteCompare());
        }

        public ICommand SettingsCommand { get; }
        public ICommand SaveCommand { get; }
        public ICommand ImportCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand OpenCommand { get; }
        public ICommand RotateCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand OrderByCommand { get; }
        public ICommand CompareCommand { get; }

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

        private void ExecuteOpen()
        {
            SelectedPhoto.RedundantPhotos.First().IsChecked = !SelectedPhoto.RedundantPhotos.First().IsChecked;
        }

        private void ExecuteRotate()
        {
        }

        private void ExecuteDelete()
        {
        }

        private void ExecuteOrderBy()
        {
        }

        private void ExecuteCompare()
        {
        }

        public IPhotoModel SelectedPhoto
        {
            get => Model.SelectedPhoto;
            set
            {
                if (value == Model.SelectedPhoto) return;

                Model.SelectedPhoto = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ShowDetailsPane));
            }
        }

        public bool ShowRedundantPhotos
        {
            get => Model.ShowRedundantPhotos;
            set
            {
                if (value == Model.ShowRedundantPhotos) return;

                Model.ShowRedundantPhotos = value;
                OnPropertyChanged();
            }
        }

        public bool ShowDetails
        {
            get => Model.ShowDetails;
            set
            {
                if (value == ShowDetails) return;

                Model.ShowDetails = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ShowDetailsPane));
            }
        }

        public bool ShowDescription
        {
            get => Model.ShowDescription;
            set
            {
                if (value == ShowDescription) return;

                Model.ShowDescription = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ShowDetailsPane));
            }
        }

        public bool ShowDetailsPane => Model.ShowDetailsPane;

        public IObservableCollection<IPhotoModel> Images => Model.Images;
    }
}