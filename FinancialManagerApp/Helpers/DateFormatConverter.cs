using System;
using System.Globalization;
using System.Windows.Data;

namespace FinancialManagerApp.Helpers
{
    public class DateFormatConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTime dateTime)
            {
                return dateTime.ToString("yyyy-MM-dd");
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string stringValue)
            {
                if (DateTime.TryParseExact(stringValue, "yyyy-MM-dd", culture, DateTimeStyles.None, out DateTime dateTime))
                {
                    return dateTime;
                }
            }
            return value;
        }
    }
}
