using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IPhotoService
    {
        Task<IList<IPhotoModel>> ImportPhotos();
    }
}