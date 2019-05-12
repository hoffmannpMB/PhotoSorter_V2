using Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Storage;

namespace Repository
{
    public interface IPhotoRepository
    {
        Task<IReadOnlyList<StorageFile>> GetPhotosAsync();
    }
}