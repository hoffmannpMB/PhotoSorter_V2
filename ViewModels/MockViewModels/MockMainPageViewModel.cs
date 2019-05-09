using System.Collections.ObjectModel;
using ViewModels.Implementations;

namespace ViewModels.MockViewModels
{
    public class MockMainPageViewModel : MainPageViewModel
    {
        public MockMainPageViewModel()
        {
            Images = new ObservableCollection<string>
            {
                @"TestImages/leopard1.jpg",
                @"TestImages/leopard2.jpg"
            };
        }
    }
}