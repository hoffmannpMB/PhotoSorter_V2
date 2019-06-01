using System;
using MVVM_Base.Properties;

namespace MVVM_Base
{
    public interface INavigationService
    {
        void NavigateTo(string viewType);

        void NavigateTo<TViewModel>(string pageKey, [NotNull] TViewModel viewModel) where TViewModel : ViewModelBase;

        void NavigateBack();

        void Register(string key, Type page);
    }
}