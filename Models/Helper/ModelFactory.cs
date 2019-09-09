using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Storage;
using Models.Implementations;

namespace Models.Helper
{
    public class ModelFactory : IModelFactory
    {
        public async Task<IPhotoModel> CreateAsync(StorageFile sourceFile, StorageFile tmpStorageFile)
        {
            var metaData = await sourceFile.Properties.GetImagePropertiesAsync();
            var extraProperties = await sourceFile.Properties.RetrievePropertiesAsync(new List<string> {"System.Comment"});

            var model = new PhotoModel
            {
                CameraModel = new CameraModel
                {
                    CameraType = metaData.CameraModel,
                    Manufacturer = metaData.CameraManufacturer
                },
                DateTaken = metaData.DateTaken.DateTime,
                Description = extraProperties["System.Comment"]?.ToString(),
                ImageName = sourceFile.Name,
                ImagePath = sourceFile.Path,
                TmpImagePath = tmpStorageFile.Path
            };

            return model;
        }
    }
}