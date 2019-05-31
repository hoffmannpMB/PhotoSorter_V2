using Models;
using Models.Implementations;
using MVVM_Base;
using MVVM_Base.Implementations;
using System.Windows.Input;

namespace ViewModels.MockViewModels
{
    public class MockMainPageViewModel : IMainPageViewModel
    {
        public MockMainPageViewModel()
        {
            Images = new AdvancedObservableCollection<IPhotoModel>
            {
                new PhotoModel { ImagePath = @"TestImages/leopard1.jpg", RedundantPhotos =
                {
                    new RedundantPhotoModel { ImagePath = @"TestImages/leopard1.jpg"},
                    new RedundantPhotoModel { ImagePath = @"TestImages/leopard1.jpg"},
                    new RedundantPhotoModel { ImagePath = @"TestImages/leopard1.jpg"}
                }},
                new PhotoModel { ImagePath = @"TestImages/leopard2.jpg" }
            };
            ShowRedundantPhotos = true;
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
        public bool ShowRedundantPhotos { get; set; }
        public bool ShowDetailsPane { get; }
        public bool ShowDetails { get; set; }
        public bool ShowDescription { get; set; }
        public IPhotoModel SelectedPhoto { get; set; }
        public IObservableCollection<IPhotoModel> Images { get; }
    }
}