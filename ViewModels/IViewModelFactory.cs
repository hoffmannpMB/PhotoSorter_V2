using Models;

namespace ViewModels
{
    public interface IViewModelFactory
    {
        IRedundantPhotoViewModel Create(IRedundantPhotoModel model);
        IPhotoViewModel Create(IPhotoModel model);
    }
}