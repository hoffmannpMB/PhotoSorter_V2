using MVVM_Base;
using Windows.UI.Xaml;
using Models;

// Die Elementvorlage "Benutzersteuerelement" wird unter https://go.microsoft.com/fwlink/?LinkId=234236 dokumentiert.

namespace CustomControls
{
    public sealed partial class RedundantPhotos
    {
        public static readonly DependencyProperty RedundantPhotosCollectionProperty = DependencyProperty.Register("RedundantPhotosCollection", typeof(IObservableCollection<IRedundantPhotoModel>), typeof(RedundantPhotos), new PropertyMetadata(default(IObservableCollection<IRedundantPhotoModel>)));
        public static readonly DependencyProperty HeaderProperty = DependencyProperty.Register("Header", typeof(string), typeof(RedundantPhotos), new PropertyMetadata(default(string)));
        public static readonly DependencyProperty IsSelectAllCheckedProperty = DependencyProperty.Register("IsSelectAllChecked", typeof(bool?), typeof(RedundantPhotos), new PropertyMetadata(default(bool?)));

        public RedundantPhotos()
        {
            InitializeComponent();
        }

        public IObservableCollection<IRedundantPhotoModel> RedundantPhotosCollection
        {
            get => (IObservableCollection<IRedundantPhotoModel>)GetValue(RedundantPhotosCollectionProperty);
            set => SetValue(RedundantPhotosCollectionProperty, value);
        }

        public string Header
        {
            get => (string)GetValue(HeaderProperty);
            set => SetValue(HeaderProperty, value);
        }

        public bool? IsSelectAllChecked
        {
            get => (bool?)GetValue(IsSelectAllCheckedProperty);
            set => SetValue(IsSelectAllCheckedProperty, value);
        }
    }
}
