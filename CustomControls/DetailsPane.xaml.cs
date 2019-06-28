using System;
using Windows.UI.Xaml;

// Die Elementvorlage "Benutzersteuerelement" wird unter https://go.microsoft.com/fwlink/?LinkId=234236 dokumentiert.

namespace CustomControls
{
    public sealed partial class DetailsPane
    {
        public static readonly DependencyProperty ImagePathHeaderProperty = DependencyProperty.Register("ImagePathHeader", typeof(string), typeof(DetailsPane), new PropertyMetadata(default(string)));
        public static readonly DependencyProperty ImagePathPlaceHolderProperty = DependencyProperty.Register("ImagePathPlaceHolder", typeof(string), typeof(DetailsPane), new PropertyMetadata(default(string)));
        public static readonly DependencyProperty ImagePathTextProperty = DependencyProperty.Register("ImagePathText", typeof(string), typeof(DetailsPane), new PropertyMetadata(default(string)));
        public static readonly DependencyProperty DateTakenHeaderProperty = DependencyProperty.Register("DateTakenHeader", typeof(string), typeof(DetailsPane), new PropertyMetadata(default(string)));
        public static readonly DependencyProperty DateTakenDateProperty = DependencyProperty.Register("DateTakenDate", typeof(DateTimeOffset), typeof(DetailsPane), new PropertyMetadata(default(DateTimeOffset)));
        public static readonly DependencyProperty DateTakenTimeProperty = DependencyProperty.Register("DateTakenTime", typeof(TimeSpan), typeof(DetailsPane), new PropertyMetadata(default(TimeSpan)));
        public static readonly DependencyProperty CameraModelPlaceHolderProperty = DependencyProperty.Register("CameraModelPlaceHolder", typeof(string), typeof(DetailsPane), new PropertyMetadata(default(string)));
        public static readonly DependencyProperty CameraModelNameProperty = DependencyProperty.Register("CameraModelName", typeof(string), typeof(DetailsPane), new PropertyMetadata(default(string)));
        public static readonly DependencyProperty CameraModelHeaderProperty = DependencyProperty.Register("CameraModelHeader", typeof(string), typeof(DetailsPane), new PropertyMetadata(default(string)));

        public DetailsPane()
        {
            InitializeComponent();
        }

        public string ImagePathHeader
        {
            get => (string)GetValue(ImagePathHeaderProperty);
            set => SetValue(ImagePathHeaderProperty, value);
        }

        public string ImagePathPlaceHolder
        {
            get => (string)GetValue(ImagePathPlaceHolderProperty);
            set => SetValue(ImagePathPlaceHolderProperty, value);
        }

        public string ImagePathText
        {
            get => (string)GetValue(ImagePathTextProperty);
            set => SetValue(ImagePathTextProperty, value);
        }

        public string DateTakenHeader
        {
            get => (string)GetValue(DateTakenHeaderProperty);
            set => SetValue(DateTakenHeaderProperty, value);
        }

        public DateTimeOffset DateTakenDate
        {
            get => (DateTimeOffset)GetValue(DateTakenDateProperty);
            set => SetValue(DateTakenDateProperty, value);
        }

        public TimeSpan DateTakenTime
        {
            get => (TimeSpan)GetValue(DateTakenTimeProperty);
            set => SetValue(DateTakenTimeProperty, value);
        }

        public string CameraModelPlaceHolder
        {
            get => (string)GetValue(CameraModelPlaceHolderProperty);
            set => SetValue(CameraModelPlaceHolderProperty, value);
        }

        public string CameraModelName
        {
            get => (string)GetValue(CameraModelNameProperty);
            set => SetValue(CameraModelNameProperty, value);
        }

        public string CameraModelHeader
        {
            get => (string)GetValue(CameraModelHeaderProperty);
            set => SetValue(CameraModelHeaderProperty, value);
        }
    }
}
