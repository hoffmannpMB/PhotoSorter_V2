using System;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace CustomControls.Converter
{
    public class SimilarityToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if ((float)value < 33.3)
                return new SolidColorBrush(Color.FromArgb(120, 50, 205, 50));

            return (float)value < 66.6 ? new SolidColorBrush(Color.FromArgb(120, 255, 255, 0)) : new SolidColorBrush(Color.FromArgb(120, 255, 0, 0));
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}