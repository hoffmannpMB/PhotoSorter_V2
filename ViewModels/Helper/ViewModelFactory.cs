using Models;
using Models.Implementations;
using MVVM_Base;
using MVVM_Base.Messenger;
using ViewModels.Implementations;

namespace ViewModels.Helper
{
    public class ViewModelFactory : IViewModelFactory
    {
        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationService;

        public ViewModelFactory(IMessenger messenger, INavigationService navigationService)
        {
            _messenger = messenger;
            _navigationService = navigationService;
        }

        public IRedundantPhotoViewModel Create(IRedundantPhotoModel model)
        {
            return new RedundantPhotoViewModel { Model = (RedundantPhotoModel)model };
        }

        public IPhotoViewModel Create(IPhotoModel model)
        {
            return new PhotoViewModel(_messenger, _navigationService) { Model = (PhotoModel)model };
        }
    }
}