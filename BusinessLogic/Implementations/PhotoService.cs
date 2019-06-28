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
            var files = await _photoRepository.GetPhotosAsync();
            var tmpFiles = await _photoRepository.CopyPhotosToAssetsAsync(files);
            var photos = new List<IPhotoModel>();

            for (var i = 0; i < files.Count; i++)
            {
                photos.Add(await _modelFactory.CreateAsync(files[i], tmpFiles[i]));
            }

            return photos;
        }
    }
}