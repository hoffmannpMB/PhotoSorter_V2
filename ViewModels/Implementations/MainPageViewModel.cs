using System.Threading.Tasks;
using Models;
using Models.Implementations;
using MVVM_Base;
using MVVM_Base.Messenger;
using System.Windows.Input;
using BusinessLogic;

namespace ViewModels.Implementations
{
    /// <inheritdoc cref="ViewModelBase" />
    public class MainPageViewModel : ViewModelBase<MainPageModel>, IMainPageViewModel
    {
        private readonly IViewModelFactory _factory;
        private readonly IPhotoService _photoService;

        public MainPageViewModel(INavigationService navigationService, IMessenger messenger, IViewModelFactory factory, IPhotoService photoService)
        {
            _factory = factory;
            _photoService = photoService;
            messenger.Register<string>(this, "PhotoDescription", p => { SelectedPhoto.Description = p; });
            Model.Images.Cast(factory.Create);

            SettingsCommand = new RelayCommand(p => navigationService.NavigateTo("SettingsPage"));
            SaveCommand = new RelayCommand(p => ExecuteSave());
            ImportCommand = new RelayCommand(async p => await ExecuteImport());
            OpenCommand = new RelayCommand(p => ExecuteOpen());
            RotateCommand = new RelayCommand(p => ExecuteRotate());
            DeleteCommand = new RelayCommand(p => ExecuteDelete(p as IImage));
            OrderByCommand = new RelayCommand(p => ExecuteOrderBy((bool)p));
            CompareCommand = new RelayCommand(p => ExecuteCompare());
        }

        public ICommand SettingsCommand { get; }
        public ICommand SaveCommand { get; }
        public ICommand ImportCommand { get; }
        public ICommand OpenCommand { get; }
        public ICommand RotateCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand OrderByCommand { get; }
        public ICommand CompareCommand { get; }

        private async Task ExecuteImport()
        {
            var t = await _photoService.ImportPhotos();
            t.Cast(_factory.Create);
            Images.AddRange(t);
        }

        private void ExecuteSave()
        {
            // copy photos to project location
            // create/edit xml
        }

        private void ExecuteOpen()
        {
        }

        private void ExecuteRotate()
        {
            SelectedPhoto.Rotation = (SelectedPhoto.Rotation + 90) % 360;
        }

        private void ExecuteDelete(IImage image)
        {
            if (image == null) return;

            Images.Remove(i => i.ImagePath.Equals(image.ImagePath));

            foreach (var photoModel in Images)
                photoModel.RedundantPhotos.Remove(i => i.ImagePath.Equals(image.ImagePath));
        }

        private void ExecuteOrderBy(bool @descending)
        {
            Images.SortBy(p => p.DateTaken, descending);
        }

        private void ExecuteCompare()
        {
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

        public IObservableCollection<IPhotoModel> Images => Model.Images;

        public bool ShowDetailsPane => Model.ShowDetailsPane;
    }
}