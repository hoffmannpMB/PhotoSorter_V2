using System.Collections.ObjectModel;

namespace ViewModels
{
    public interface IMainPageViewModel
    {
        ObservableCollection<string> Images { get; set; }
    }
}