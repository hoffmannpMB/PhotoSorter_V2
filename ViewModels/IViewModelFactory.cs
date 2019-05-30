using Models;
using Models.Implementations;
using ViewModels.Implementations;

namespace ViewModels
{
    public interface IViewModelFactory
    {
        IRedundantPhotoViewModel Create(IRedundantPhotoModel model);
    }

    public class ViewModelFactory : IViewModelFactory
    {
        public IRedundantPhotoViewModel Create(IRedundantPhotoModel model)
        {
            return new RedundantPhotoViewModel { Model = (RedundantPhotoModel)model };
        }
    }
}