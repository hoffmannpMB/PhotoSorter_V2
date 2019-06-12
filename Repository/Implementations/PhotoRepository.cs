using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.ApplicationModel;
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
                ViewMode = PickerViewMode.Thumbnail,
                SuggestedStartLocation = PickerLocationId.PicturesLibrary,
                FileTypeFilter = { ".jpg", ".jpeg", ".png" }
            };

            return await picker.PickMultipleFilesAsync();
        }

        public async Task<IEnumerable<StorageFile>> CopyPhotosToAssetsAsync(IEnumerable<StorageFile> files)
        {
            var assetFiles = new List<StorageFile>();
            var storageFolder = await Package.Current.InstalledLocation.GetFolderAsync("Assets");

            foreach (var file in files)
            {
                assetFiles.Add(await file.CopyAsync(storageFolder, $"tmp - {file.Name}", NameCollisionOption.GenerateUniqueName));
            }

            return assetFiles;
        }
    }
}