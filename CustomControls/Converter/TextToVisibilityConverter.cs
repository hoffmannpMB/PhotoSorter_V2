using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace CustomControls.Converter
{
    public class TextToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return string.IsNullOrWhiteSpace((string)value) ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return !string.IsNullOrWhiteSpace((string)value) ? Visibility.Collapsed : Visibility.Visible;
        }
    }
}