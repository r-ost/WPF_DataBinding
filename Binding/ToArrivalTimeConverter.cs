using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;

namespace Binding
{
    public class ToArrivalTimeConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] == DependencyProperty.UnsetValue)
                return DependencyProperty.UnsetValue;

            var result = (DateTime) values[0];
            var timeSpan = (TimeSpan)values[1];
            result = result.Add(timeSpan);

            //return (DateTime)result;
            return result.ToString();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}