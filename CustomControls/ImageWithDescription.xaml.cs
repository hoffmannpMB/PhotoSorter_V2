// Die Elementvorlage "Benutzersteuerelement" wird unter https://go.microsoft.com/fwlink/?LinkId=234236 dokumentiert.

using Windows.UI.Text;
using Windows.UI.Xaml;

namespace CustomControls
{
    public sealed partial class ImageWithDescription
    {
        public static readonly DependencyProperty RtfTextProperty = DependencyProperty.Register("RtfText", typeof(string), typeof(ImageWithDescription), new PropertyMetadata(default(string)));
        public static readonly DependencyProperty SourceProperty = DependencyProperty.Register("Source", typeof(string), typeof(ImageWithDescription), new PropertyMetadata(default(string)));

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

        private void FrameworkElement_OnLoaded(object sender, RoutedEventArgs e)
        {
            if (RtfText == null) return;

            ((Windows.UI.Xaml.Controls.RichEditBox) sender).Document.SetText(TextSetOptions.FormatRtf, RtfText);
        }
    }
}
