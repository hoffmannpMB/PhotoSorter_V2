using Models;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// Die Elementvorlage "Benutzersteuerelement" wird unter https://go.microsoft.com/fwlink/?LinkId=234236 dokumentiert.

namespace CustomControls
{
    public sealed partial class FlipViewWithPageIndicator : UserControl
    {
        public FlipViewWithPageIndicator()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty ImagesProperty = DependencyProperty.Register(
            "Images", typeof(ObservableCollection<IPhotoModel>), typeof(FlipViewWithPageIndicator), new PropertyMetadata(default(ObservableCollection<string>)));
        public static readonly DependencyProperty SelectedImageProperty = DependencyProperty.Register("SelectedImage", typeof(IPhotoModel), typeof(FlipViewWithPageIndicator), new PropertyMetadata(default(IPhotoModel)));

        public ObservableCollection<IPhotoModel> Images
        {
            get => (ObservableCollection<IPhotoModel>)GetValue(ImagesProperty);
            set => SetValue(ImagesProperty, value);
        }

        public IPhotoModel SelectedImage
        {
            get => (IPhotoModel)GetValue(SelectedImageProperty);
            set => SetValue(SelectedImageProperty, value);
        }
    }
}
