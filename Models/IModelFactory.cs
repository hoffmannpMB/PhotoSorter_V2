using System.Threading.Tasks;
using Windows.Storage;

namespace Models
{
    public interface IModelFactory
    {
        Task<IPhotoModel> CreateAsync(StorageFile storageFile);
    }
}