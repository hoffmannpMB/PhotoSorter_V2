using MVVM_Base;
using ViewModels;
using Windows.UI.Xaml;

// Die Elementvorlage "Benutzersteuerelement" wird unter https://go.microsoft.com/fwlink/?LinkId=234236 dokumentiert.

namespace CustomControls
{
    public sealed partial class RedundantPhotos
    {
        public static readonly DependencyProperty RedundantPhotosCollectionProperty = DependencyProperty.Register("RedundantPhotosCollection", typeof(IObservableCollection<IRedundantPhotoViewModel>), typeof(RedundantPhotos), new PropertyMetadata(default(IObservableCollection<IRedundantPhotoViewModel>)));
        public static readonly DependencyProperty HeaderProperty = DependencyProperty.Register("Header", typeof(string), typeof(RedundantPhotos), new PropertyMetadata(default(string)));
        public static readonly DependencyProperty IsSelectAllCheckedProperty = DependencyProperty.Register("IsSelectAllChecked", typeof(bool?), typeof(RedundantPhotos), new PropertyMetadata(default(bool?)));

        public RedundantPhotos()
        {
            InitializeComponent();
        }

        public IObservableCollection<IRedundantPhotoViewModel> RedundantPhotosCollection
        {
            get => (IObservableCollection<IRedundantPhotoViewModel>)GetValue(RedundantPhotosCollectionProperty);
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
