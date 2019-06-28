using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Storage;

namespace Repository
{
    public interface IPhotoRepository
    {
        Task<IReadOnlyList<StorageFile>> GetPhotosAsync();
        Task<IReadOnlyList<StorageFile>> CopyPhotosToAssetsAsync(IEnumerable<StorageFile> files);
    }
}