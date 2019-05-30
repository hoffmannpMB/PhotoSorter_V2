using Models.Implementations;
using MVVM_Base;

namespace ViewModels.Implementations
{
    public class RedundantPhotoViewModel : ViewModelBase<RedundantPhotoModel>, IRedundantPhotoViewModel
    {
        public string ImagePath
        {
            get => Model.ImagePath;
            set
            {
                if (value == Model.ImagePath) return;

                Model.ImagePath = value;
                OnPropertyChanged();
            }
        }

        public float Similarity
        {
            get => Model.Similarity;
            set
            {
                if (value == Model.Similarity) return;

                Model.Similarity = value;
                OnPropertyChanged();
            }
        }

        public bool? IsChecked
        {
            get => Model.IsChecked;
            set
            {
                if (value == Model.IsChecked) return;

                Model.IsChecked = value;
                OnPropertyChanged();
            }
        }
    }
}