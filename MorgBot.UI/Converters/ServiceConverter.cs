using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MorgBot.UI.Converters
{
    public class ServiceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is string))
                throw new Exception("ServiceConverter: Value must be a Service!");

            switch ((string)value)
            {
                case "Beam":
                    return "Images/beam.png";
                case "Hitbox":
                    return "Images/hitbox.png";
                case "Twitch":
                    return "Images/twitch.png";
                case "All":
                    throw new Exception("ServiceConverter: No image for all services.");
                default:
                    return "Please choose a valid service.";

            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new Exception("ServiceConverter: Converting from string to Eservice is a work in progress.");
        }
    }
}
