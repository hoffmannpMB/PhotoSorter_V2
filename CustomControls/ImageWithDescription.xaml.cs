// Die Elementvorlage "Benutzersteuerelement" wird unter https://go.microsoft.com/fwlink/?LinkId=234236 dokumentiert.

using System;
using Windows.UI.Text;
using Windows.UI.Xaml;

namespace CustomControls
{
    public sealed partial class ImageWithDescription
    {
        public static readonly DependencyProperty RtfTextProperty = DependencyProperty.Register("RtfText", typeof(string), typeof(ImageWithDescription), new PropertyMetadata(default(string)));
        public static readonly DependencyProperty SourceProperty = DependencyProperty.Register("Source", typeof(string), typeof(ImageWithDescription), new PropertyMetadata(default(string)));
        public static readonly DependencyProperty IsPaneOpenProperty = DependencyProperty.Register("IsPaneOpen", typeof(bool), typeof(ImageWithDescription), new PropertyMetadata(default(bool)));
        public static readonly DependencyProperty ImagePathHeaderProperty = DependencyProperty.Register("ImagePathHeader", typeof(string), typeof(ImageWithDescription), new PropertyMetadata(default(string)));
        public static readonly DependencyProperty ImagePathPlaceHolderProperty = DependencyProperty.Register("ImagePathPlaceHolder", typeof(string), typeof(ImageWithDescription), new PropertyMetadata(default(string)));
        public static readonly DependencyProperty ImagePathTextProperty = DependencyProperty.Register("ImagePathText", typeof(string), typeof(ImageWithDescription), new PropertyMetadata(default(string)));
        public static readonly DependencyProperty DateTakenHeaderProperty = DependencyProperty.Register("DateTakenHeader", typeof(string), typeof(ImageWithDescription), new PropertyMetadata(default(string)));
        public static readonly DependencyProperty DateTakenDateProperty = DependencyProperty.Register("DateTakenDate", typeof(DateTime), typeof(ImageWithDescription), new PropertyMetadata(default(DateTime)));
        public static readonly DependencyProperty CameraModelHeaderProperty = DependencyProperty.Register("CameraModelHeader", typeof(string), typeof(ImageWithDescription), new PropertyMetadata(default(string)));
        public static readonly DependencyProperty CameraModelPlaceHolderProperty = DependencyProperty.Register("CameraModelPlaceHolder", typeof(string), typeof(ImageWithDescription), new PropertyMetadata(default(string)));
        public static readonly DependencyProperty CameraModelNameProperty = DependencyProperty.Register("CameraModelName", typeof(string), typeof(ImageWithDescription), new PropertyMetadata(default(string)));
        public static readonly DependencyProperty DescriptionHeaderProperty = DependencyProperty.Register("DescriptionHeader", typeof(string), typeof(ImageWithDescription), new PropertyMetadata(default(string)));
        public static readonly DependencyProperty ShowDetailsProperty = DependencyProperty.Register("ShowDetails", typeof(Visibility), typeof(ImageWithDescription), new PropertyMetadata(default(Visibility)));
        public static readonly DependencyProperty ShowDescriptionProperty = DependencyProperty.Register("ShowDescription", typeof(Visibility), typeof(ImageWithDescription), new PropertyMetadata(default(Visibility)));

        public ImageWithDescription()
        {
            InitializeComponent();
        }

        public string RtfText
        {
            get => (string)GetValue(RtfTextProperty);
            set => SetValue(RtfTextProperty, value);
        }

        public string Source
        {
            get => (string)GetValue(SourceProperty);
            set => SetValue(SourceProperty, value);
        }

        public bool IsPaneOpen
        {
            get => (bool)GetValue(IsPaneOpenProperty);
            set => SetValue(IsPaneOpenProperty, value);
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

        public DateTime DateTakenDate
        {
            get => (DateTime)GetValue(DateTakenDateProperty);
            set => SetValue(DateTakenDateProperty, value);
        }

        public string CameraModelHeader
        {
            get => (string)GetValue(CameraModelHeaderProperty);
            set => SetValue(CameraModelHeaderProperty, value);
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

        public string DescriptionHeader
        {
            get => (string)GetValue(DescriptionHeaderProperty);
            set => SetValue(DescriptionHeaderProperty, value);
        }

        public Visibility ShowDetails
        {
            get => (Visibility)GetValue(ShowDetailsProperty);
            set => SetValue(ShowDetailsProperty, value);
        }

        public Visibility ShowDescription
        {
            get => (Visibility)GetValue(ShowDescriptionProperty);
            set => SetValue(ShowDescriptionProperty, value);
        }

        private void FrameworkElement_OnLoaded(object sender, RoutedEventArgs e)
        {
            if (RtfText == null) return;

            ((Windows.UI.Xaml.Controls.RichEditBox)sender).Document.SetText(TextSetOptions.FormatRtf, RtfText);
        }
    }
}