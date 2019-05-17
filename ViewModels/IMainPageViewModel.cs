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

        IPhotoModel SelectedPhoto { get; set; }

        IRangeObservableCollection<IPhotoModel> Images { get; }
    }
}