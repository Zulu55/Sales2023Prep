using System;
using System.Globalization;

namespace Sales.Mobile.MVVM.Converters
{
	public class BoolConverter : IValueConverter
	{
		public BoolConverter()
		{
		}

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var boolValue = (bool)value;
            if (boolValue)
            {
                return "Sí";
            }
            return "No";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var stringValue = value.ToString();
            if (stringValue == "Sí")
            {
                return true;
            }
            return false;
        }
    }
}

