using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace SoundChecker.Infrastructure
{
    public class InvertedBooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var bValue = false;
            if (value is bool)
            {
                bValue = (bool)value;
            }

            return (bValue) ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if (value is Visibility)
            {
                return (Visibility)value == Visibility.Collapsed;
            }

            return false;
        }
    }
}