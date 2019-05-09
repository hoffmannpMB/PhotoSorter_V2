using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// Die Elementvorlage "Benutzersteuerelement" wird unter https://go.microsoft.com/fwlink/?LinkId=234236 dokumentiert.

namespace CustomControls
{
    public sealed partial class FlipViewWithPageIndicator : UserControl
    {
        public FlipViewWithPageIndicator()
        {
            Images = new ObservableCollection<string>
            {
                @"TestImages/leopard1.jpg",
                @"TestImages/leopard2.jpg"
            };

            InitializeComponent();
        }

        //------------------------------------------------------
        //--------------FlipView--------------------------------
        //------------------------------------------------------

        public static readonly DependencyProperty ImagesProperty = DependencyProperty.Register(
            "Images", typeof(ObservableCollection<string>), typeof(FlipViewWithPageIndicator), new PropertyMetadata(default(ObservableCollection<string>)));

        public ObservableCollection<string> Images
        {
            get { return (ObservableCollection<string>) GetValue(ImagesProperty); }
            set { SetValue(ImagesProperty, value); }
        }
    }
}
