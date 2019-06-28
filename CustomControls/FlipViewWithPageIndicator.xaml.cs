using Models;
using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;

// Die Elementvorlage "Benutzersteuerelement" wird unter https://go.microsoft.com/fwlink/?LinkId=234236 dokumentiert.

namespace CustomControls
{
    public sealed partial class FlipViewWithPageIndicator
    {
        public FlipViewWithPageIndicator()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty ImagesProperty = DependencyProperty.Register("Images", typeof(ObservableCollection<IPhotoModel>), typeof(FlipViewWithPageIndicator), new PropertyMetadata(default(ObservableCollection<string>)));
        public static readonly DependencyProperty SelectedImageProperty = DependencyProperty.Register("SelectedImage", typeof(IPhotoModel), typeof(FlipViewWithPageIndicator), new PropertyMetadata(default(IPhotoModel)));
        public static readonly DependencyProperty ImagePathPlaceHolderProperty = DependencyProperty.Register("ImagePathPlaceHolder", typeof(string), typeof(FlipViewWithPageIndicator), new PropertyMetadata(default(string)));
        public static readonly DependencyProperty ImagePathHeaderProperty = DependencyProperty.Register("ImagePathHeader", typeof(string), typeof(FlipViewWithPageIndicator), new PropertyMetadata(default(string)));
        public static readonly DependencyProperty DateTakenHeaderProperty = DependencyProperty.Register("DateTakenHeader", typeof(string), typeof(FlipViewWithPageIndicator), new PropertyMetadata(default(string)));
        public static readonly DependencyProperty CameraModelHeaderProperty = DependencyProperty.Register("CameraModelHeader", typeof(string), typeof(FlipViewWithPageIndicator), new PropertyMetadata(default(string)));
        public static readonly DependencyProperty DescriptionHeaderProperty = DependencyProperty.Register("DescriptionHeader", typeof(string), typeof(FlipViewWithPageIndicator), new PropertyMetadata(default(string)));
        public static readonly DependencyProperty CameraModelPlaceHolderProperty = DependencyProperty.Register("CameraModelPlaceHolder", typeof(string), typeof(FlipViewWithPageIndicator), new PropertyMetadata(default(string)));
        public static readonly DependencyProperty PhotoNamePlaceHolderProperty = DependencyProperty.Register("PhotoNamePlaceHolder", typeof(string), typeof(FlipViewWithPageIndicator), new PropertyMetadata(default(string)));
        public static readonly DependencyProperty PhotoNameProperty = DependencyProperty.Register("PhotoName", typeof(string), typeof(FlipViewWithPageIndicator), new PropertyMetadata(default(string)));
        public static readonly DependencyProperty TestDateProperty = DependencyProperty.Register("TestDate", typeof(DateTimeOffset), typeof(FlipViewWithPageIndicator), new PropertyMetadata(default(DateTimeOffset)));

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

        public string ImagePathPlaceHolder
        {
            get => (string)GetValue(ImagePathPlaceHolderProperty);
            set => SetValue(ImagePathPlaceHolderProperty, value);
        }

        public string ImagePathHeader
        {
            get => (string)GetValue(ImagePathHeaderProperty);
            set => SetValue(ImagePathHeaderProperty, value);
        }

        public string DateTakenHeader
        {
            get => (string)GetValue(DateTakenHeaderProperty);
            set => SetValue(DateTakenHeaderProperty, value);
        }

        public string CameraModelHeader
        {
            get => (string)GetValue(CameraModelHeaderProperty);
            set => SetValue(CameraModelHeaderProperty, value);
        }

        public string DescriptionHeader
        {
            get => (string)GetValue(DescriptionHeaderProperty);
            set => SetValue(DescriptionHeaderProperty, value);
        }

        public string CameraModelPlaceHolder
        {
            get => (string)GetValue(CameraModelPlaceHolderProperty);
            set => SetValue(CameraModelPlaceHolderProperty, value);
        }

        public string PhotoNamePlaceHolder
        {
            get => (string)GetValue(PhotoNamePlaceHolderProperty);
            set => SetValue(PhotoNamePlaceHolderProperty, value);
        }

        public string PhotoName
        {
            get => (string)GetValue(PhotoNameProperty);
            set => SetValue(PhotoNameProperty, value);
        }

        public DateTimeOffset TestDate
        {
            get => (DateTimeOffset)GetValue(TestDateProperty);
            set => SetValue(TestDateProperty, value);
        }
    }
}
