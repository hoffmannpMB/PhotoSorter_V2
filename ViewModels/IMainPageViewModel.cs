using Models;
using MVVM_Base;
using System.Windows.Input;

namespace ViewModels
{
    public interface IMainPageViewModel
    {
        ICommand SettingsCommand { get; }
        ICommand SaveCommand { get; }
        ICommand ImportCommand { get; }
        ICommand EditCommand { get; }
        ICommand ToggleShowRedundantPhotosCommand { get; }

        bool IsPaneOpen { get; set; }
        IPhotoModel SelectedPhoto { get; set; }

        IObservableCollection<IPhotoModel> Images { get; }
    }
}