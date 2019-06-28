using Models;
using MVVM_Base;
using System.Windows.Input;
using Windows.UI.Xaml;

// Die Elementvorlage "Benutzersteuerelement" wird unter https://go.microsoft.com/fwlink/?LinkId=234236 dokumentiert.

namespace CustomControls
{
    public sealed partial class RedundantPhotos
    {
        public static readonly DependencyProperty RedundantPhotosCollectionProperty = DependencyProperty.Register("RedundantPhotosCollection", typeof(IObservableCollection<IRedundantPhotoModel>), typeof(RedundantPhotos), new PropertyMetadata(default(IObservableCollection<IRedundantPhotoModel>)));
        public static readonly DependencyProperty HeaderProperty = DependencyProperty.Register("Header", typeof(string), typeof(RedundantPhotos), new PropertyMetadata(default(string)));
        public static readonly DependencyProperty DeleteItemCommandProperty = DependencyProperty.Register("DeleteItemCommand", typeof(ICommand), typeof(RedundantPhotos), new PropertyMetadata(default(ICommand)));
        public static readonly DependencyProperty SelectedRedundantImageProperty = DependencyProperty.Register("SelectedRedundantImage", typeof(IRedundantPhotoModel), typeof(RedundantPhotos), new PropertyMetadata(default(IRedundantPhotoModel)));

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

        public ICommand DeleteItemCommand
        {
            get => (ICommand)GetValue(DeleteItemCommandProperty);
            set => SetValue(DeleteItemCommandProperty, value);
        }

        public IRedundantPhotoModel SelectedRedundantImage
        {
            get => (IRedundantPhotoModel)GetValue(SelectedRedundantImageProperty);
            set => SetValue(SelectedRedundantImageProperty, value);
        }
    }
}
