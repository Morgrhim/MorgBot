using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace MorgBot.UI.Converters
{
    class BoolToStatusConverter : IValueConverter
    {

        /// <summary>
        /// Converts a boolean to a Color.
        /// </summary>
        /// <param name="value">The boolean</param>
        /// <param name="targetType">The target type</param>
        /// <param name="parameter">The parameter</param>
        /// <param name="culture">CultureInfo</param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is bool))
            {
                throw new Exception("BoolToStatusConverter: Value must be a bool!");
            }

            if ((bool)value == true) return new SolidColorBrush(Colors.Green);
            else return new SolidColorBrush(Colors.Red);
        }

        /// <summary>
        /// Converts a Color to a boolean value.
        /// </summary>
        /// <param name="value">The color.</param>
        /// <param name="targetType">The target type</param>
        /// <param name="parameter">The parameter</param>
        /// <param name="culture">CultureInfo</param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is Color))
            {
                throw new Exception("BoolToStatusConverter: Value must be a color!");
            }

            if ((Color)value == Colors.Green) return true;
            else return false;
        }
    }
}
