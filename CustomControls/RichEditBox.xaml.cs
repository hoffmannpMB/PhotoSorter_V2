// Die Elementvorlage "Benutzersteuerelement" wird unter https://go.microsoft.com/fwlink/?LinkId=234236 dokumentiert.

using Windows.UI.Text;
using Windows.UI.Xaml;

namespace CustomControls
{
    public sealed partial class RichEditBox
    {
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(RichEditBox), new PropertyMetadata(default(string)));

        public RichEditBox()
        {
            InitializeComponent();
        }

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set
            {
                SetValue(TextProperty, value);
                Editor.Document.SetText(TextSetOptions.None, value);
            }
        }

        private void BoldButton_OnClick(object sender, RoutedEventArgs e)
        {
            var selectedText = Editor.Document.Selection;

            if (selectedText == null) return;

            var charFormatting = selectedText.CharacterFormat;
            charFormatting.Bold = Windows.UI.Text.FormatEffect.Toggle;
            selectedText.CharacterFormat = charFormatting;
        }

        private void ItalicButton_OnClick(object sender, RoutedEventArgs e)
        {
            var selectedText = Editor.Document.Selection;

            if (selectedText == null) return;

            var charFormatting = selectedText.CharacterFormat;
            charFormatting.Italic = Windows.UI.Text.FormatEffect.Toggle;
            selectedText.CharacterFormat = charFormatting;
        }

        private void UnderlineButton_OnClick(object sender, RoutedEventArgs e)
        {
            var selectedText = Editor.Document.Selection;

            if (selectedText == null) return;

            var charFormatting = selectedText.CharacterFormat;
            charFormatting.Underline = charFormatting.Underline == Windows.UI.Text.UnderlineType.None ? Windows.UI.Text.UnderlineType.Single : Windows.UI.Text.UnderlineType.None;
            selectedText.CharacterFormat = charFormatting;
        }
    }
}
