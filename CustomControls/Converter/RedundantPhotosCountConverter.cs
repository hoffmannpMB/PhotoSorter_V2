using System;
using Windows.UI.Xaml.Data;

namespace CustomControls.Converter
{
    public class RedundantPhotosCountConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return (int)value <= 0 ? string.Empty : $"{value} similar photos";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}