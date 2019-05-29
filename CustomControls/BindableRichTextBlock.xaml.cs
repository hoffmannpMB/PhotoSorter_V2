// Die Elementvorlage "Benutzersteuerelement" wird unter https://go.microsoft.com/fwlink/?LinkId=234236 dokumentiert.

using Windows.UI.Text;
using Windows.UI.Xaml;

namespace CustomControls
{
    public sealed partial class BindableRichTextBlock
    {
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(BindableRichTextBlock), new PropertyMetadata(default(string)));

        public BindableRichTextBlock()
        {
            InitializeComponent();
        }

        public string Text
        {
            get { return (string) GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        private void BindableRichTextBlock_OnLoaded(object sender, RoutedEventArgs e)
        {
            if (Text == null) return;

            RichTextBlock.Document.SetText(TextSetOptions.FormatRtf, Text);
        }

        private void BindableRichTextBlock_OnTextChanged(object sender, RoutedEventArgs e)
        {
            RichTextBlock.Document.GetText(TextGetOptions.FormatRtf, out var text);
            Text = text;
        }
    }
}
