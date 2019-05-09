using System.Collections.ObjectModel;
using MVVM_Base;

namespace ViewModels.Implementations
{
    /// <inheritdoc cref="ViewModelBase" />
    public class MainPageViewModel : ViewModelBase, IMainPageViewModel
    {
        public ObservableCollection<string> Images { get; set; }
    }
}