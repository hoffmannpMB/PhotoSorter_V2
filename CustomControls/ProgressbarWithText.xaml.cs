using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// Die Elementvorlage "Benutzersteuerelement" wird unter https://go.microsoft.com/fwlink/?LinkId=234236 dokumentiert.

namespace CustomControls
{
    public sealed partial class ProgressbarWithText : UserControl
    {
        public ProgressbarWithText()
        {
            InitializeComponent();
        }

        //------------------------------------------------------
        //--------------Progressbar-----------------------------
        //------------------------------------------------------

        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
            "Value", typeof(double), typeof(ProgressbarWithText), new PropertyMetadata(default(double)));

        public double Value
        {
            get { return (double) GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }



        //------------------------------------------------------
        //--------------Text block------------------------------
        //------------------------------------------------------

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
            "Text", typeof(string), typeof(ProgressbarWithText), new PropertyMetadata(default(string)));

        public string Text
        {
            get { return (string) GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextMarginProperty = DependencyProperty.Register(
            "TextMargin", typeof(Thickness), typeof(ProgressbarWithText), new PropertyMetadata(default(Thickness)));

        public Thickness TextMargin
        {
            get { return (Thickness) GetValue(TextMarginProperty); }
            set { SetValue(TextMarginProperty, value); }
        }
    }
}
