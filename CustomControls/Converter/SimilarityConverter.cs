using System;
using Windows.UI.Xaml.Data;

namespace CustomControls.Converter
{
    public class SimilarityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return $"{value}% Similarity";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}