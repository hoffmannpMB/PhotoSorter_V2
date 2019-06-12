using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Storage;
using Models.Implementations;

namespace Models
{
    public class ModelFactory : IModelFactory
    {
        public async Task<IPhotoModel> CreateAsync(StorageFile storageFile)
        {
            var metaData = await storageFile.Properties.GetImagePropertiesAsync();
            var extraProperties = await storageFile.Properties.RetrievePropertiesAsync(new List<string> {"System.Comment"});

            var model = new PhotoModel
            {
                CameraModel = new CameraModel
                {
                    CameraType = metaData.CameraModel,
                    Manufacturer = metaData.CameraManufacturer
                },
                DateTaken = metaData.DateTaken.DateTime,
                Description = extraProperties["System.Comment"]?.ToString(),
                ImageName = storageFile.Name,
                ImagePath = storageFile.Path
            };

            return model;
        }
    }
}