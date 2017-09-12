using System;
using Windows.UI.Xaml.Data;

namespace EmptyStringDummy.Converters
{
    public class EmptyStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            //if (value is string passedvalue)
            //{
            //    if (string.IsNullOrEmpty(passedvalue))
            //        return "-empty-";
            //}
            //return value;

            if (value is string && string.IsNullOrWhiteSpace((string)value))
            {
                return "-empty-";
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
