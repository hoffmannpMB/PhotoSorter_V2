// Die Elementvorlage "Benutzersteuerelement" wird unter https://go.microsoft.com/fwlink/?LinkId=234236 dokumentiert.

using Windows.UI.Xaml;

namespace CustomControls
{
    public sealed partial class Test
    {
        public static readonly DependencyProperty IsCheckedProperty = DependencyProperty.Register("IsChecked", typeof(bool), typeof(Test), new PropertyMetadata(default(bool)));
        public static readonly DependencyProperty ImagePathProperty = DependencyProperty.Register("ImagePath", typeof(string), typeof(Test), new PropertyMetadata(default(string)));
        public static readonly DependencyProperty SimilarityProperty = DependencyProperty.Register("Similarity", typeof(string), typeof(Test), new PropertyMetadata(default(string)));
        
        public bool IsChecked
        {
            get => (bool)GetValue(IsCheckedProperty);
            set => SetValue(IsCheckedProperty, value);
        }

        public string ImagePath
        {
            get => (string)GetValue(ImagePathProperty);
            set => SetValue(ImagePathProperty, value);
        }

        public string Similarity
        {
            get => (string)GetValue(SimilarityProperty);
            set => SetValue(SimilarityProperty, value);
        }
    }
}
