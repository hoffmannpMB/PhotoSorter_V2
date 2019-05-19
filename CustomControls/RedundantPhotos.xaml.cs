using Models;
using MVVM_Base;
using Windows.UI.Xaml;

// Die Elementvorlage "Benutzersteuerelement" wird unter https://go.microsoft.com/fwlink/?LinkId=234236 dokumentiert.

namespace CustomControls
{
    public sealed partial class RedundantPhotos
    {
        public static readonly DependencyProperty RedundantPhotosCollectionProperty = DependencyProperty.Register("RedundantPhotosCollection", typeof(IObservableCollection<IPhotoModel>), typeof(RedundantPhotos), new PropertyMetadata(default(IObservableCollection<IPhotoModel>)));
        public static readonly DependencyProperty HeaderProperty = DependencyProperty.Register("Header", typeof(string), typeof(RedundantPhotos), new PropertyMetadata(default(string)));

        public RedundantPhotos()
        {
            InitializeComponent();
        }

        public IObservableCollection<IPhotoModel> RedundantPhotosCollection
        {
            get => (IObservableCollection<IPhotoModel>)GetValue(RedundantPhotosCollectionProperty);
            set => SetValue(RedundantPhotosCollectionProperty, value);
        }

        public string Header
        {
            get => (string)GetValue(HeaderProperty);
            set => SetValue(HeaderProperty, value);
        }
    }
}
