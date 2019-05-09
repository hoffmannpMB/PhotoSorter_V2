using System;

namespace MVVM_Base
{
    public interface INavigationService
    {
        void NavigateTo(string viewType);
        void NavigateBack();
        void Register(string key, Type page);
    }
}