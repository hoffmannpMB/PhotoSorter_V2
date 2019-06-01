// Die Elementvorlage "Benutzersteuerelement" wird unter https://go.microsoft.com/fwlink/?LinkId=234236 dokumentiert.

using System.Globalization;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace CustomControls
{
    public sealed partial class RichEditBox
    {
        private readonly string[] _fontNames = {
            "Arial", "Calibri", "Cambria", "Cambria Math", "Comic Sans MS", "Courier New",
            "Ebrima", "Gadugi", "Georgia",
            "Javanese Text Regular Fallback font for Javanese script", "Leelawadee UI",
            "Lucida Console", "Malgun Gothic", "Microsoft Himalaya", "Microsoft JhengHei",
            "Microsoft JhengHei UI", "Microsoft New Tai Lue", "Microsoft PhagsPa",
            "Microsoft Tai Le", "Microsoft YaHei", "Microsoft YaHei UI",
            "Microsoft Yi Baiti", "Mongolian Baiti", "MV Boli", "Myanmar Text",
            "Nirmala UI", "Segoe MDL2 Assets", "Segoe Print", "Segoe UI", "Segoe UI Emoji",
            "Segoe UI Historic", "Segoe UI Symbol", "SimSun", "Times New Roman",
            "Trebuchet MS", "Verdana", "Webdings", "Wingdings", "Yu Gothic",
            "Yu Gothic UI"
        };

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(RichEditBox), new PropertyMetadata(default(string)));

        public RichEditBox()
        {
            InitializeComponent();
            FontFamilyCbx.ItemsSource = _fontNames;
        }

        private void BoldButton_OnClick(object sender, RoutedEventArgs e)
        {
            var selectedText = Editor.Document.Selection;

            if (selectedText == null) return;

            var charFormatting = selectedText.CharacterFormat;
            charFormatting.Bold = FormatEffect.Toggle;
            selectedText.CharacterFormat = charFormatting;
        }

        private void ItalicButton_OnClick(object sender, RoutedEventArgs e)
        {
            var selectedText = Editor.Document.Selection;

            if (selectedText == null) return;

            var charFormatting = selectedText.CharacterFormat;
            charFormatting.Italic = FormatEffect.Toggle;
            selectedText.CharacterFormat = charFormatting;
        }

        private void UnderlineButton_OnClick(object sender, RoutedEventArgs e)
        {
            var selectedText = Editor.Document.Selection;

            if (selectedText == null) return;

            var charFormatting = selectedText.CharacterFormat;
            charFormatting.Underline = charFormatting.Underline == UnderlineType.None ? UnderlineType.Single : UnderlineType.None;
            selectedText.CharacterFormat = charFormatting;
        }

        private void Editor_OnSelectionChanged(object sender, RoutedEventArgs e)
        {
            var selectedText = Editor.Document.Selection;

            var charFormat = selectedText?.CharacterFormat ?? Editor.Document.GetDefaultCharacterFormat();
            FontFamilyCbx.SelectedValue = charFormat.Name;
            FontSizeBox.Text = charFormat.Size.ToString(CultureInfo.CurrentCulture);
        }

        private void FontFamily_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var charFormat = Editor.Document.Selection?.CharacterFormat ?? Editor.Document.GetDefaultCharacterFormat();
            charFormat.Name = FontFamilyCbx.SelectedValue?.ToString() ?? "Courier New";
        }

        private void Editor_OnTextChanged(object sender, RoutedEventArgs e)
        {
            Editor.Document.GetText(TextGetOptions.FormatRtf, out var text);
            Text = text;
        }

        private void RichEditBox_OnLoaded(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Text)) return;

            Editor.Document.SetText(TextSetOptions.FormatRtf, Text);
        }

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public float TextFontSize
        {
            get => (Editor.Document.Selection?.CharacterFormat ?? Editor.Document.GetDefaultCharacterFormat()).Size;
            set => (Editor.Document.Selection?.CharacterFormat ?? Editor.Document.GetDefaultCharacterFormat()).Size = value;
        }
    }
}
