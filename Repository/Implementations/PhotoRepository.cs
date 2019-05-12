using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Pickers;

namespace Repository.Implementations
{
    internal class PhotoRepository : IPhotoRepository
    {
        public async Task<IReadOnlyList<StorageFile>> GetPhotosAsync()
        {
            var picker = new FileOpenPicker
            {
                ViewMode = PickerViewMode.Thumbnail, SuggestedStartLocation = PickerLocationId.PicturesLibrary
            };

            picker.FileTypeFilter.Add(".jpg");
            picker.FileTypeFilter.Add(".jpeg");
            picker.FileTypeFilter.Add(".png");

            return await picker.PickMultipleFilesAsync();
        }
    }
}