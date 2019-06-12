using System.Collections.Generic;
using System.Threading.Tasks;
using Models;
using Repository;

namespace BusinessLogic.Implementations
{
    public class PhotoService : IPhotoService
    {
        private readonly IPhotoRepository _photoRepository;
        private readonly IModelFactory _modelFactory;

        public PhotoService(IPhotoRepository photoRepository, IModelFactory modelFactory)
        {
            _photoRepository = photoRepository;
            _modelFactory = modelFactory;
        }

        public async Task<IList<IPhotoModel>> ImportPhotos()
        {
            var files = await _photoRepository.CopyPhotosToAssetsAsync(await _photoRepository.GetPhotosAsync());
            var photos = new List<IPhotoModel>();

            foreach (var storageFile in files)
            {
                photos.Add(await _modelFactory.CreateAsync(storageFile));
            }

            return photos;
        }
    }
}