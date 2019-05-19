using System.Windows.Input;

namespace MVVM_Base
{
    public abstract  class ViewModelBaseWithBackCommand : ViewModelBase
    {
        protected ViewModelBaseWithBackCommand(INavigationService navigationService)
        {
            BackCommand = new RelayCommand(p => navigationService.NavigateBack());
        }

        public ICommand BackCommand { get; }
    }

    public abstract class ViewModelBaseWithBackCommand<T> : ViewModelBase<T>
    {
        protected ViewModelBaseWithBackCommand(INavigationService navigationService)
        {
            BackCommand = new RelayCommand(p => navigationService.NavigateBack());
        }

        public ICommand BackCommand { get; }
    }
}