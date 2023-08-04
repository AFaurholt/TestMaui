using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp1.Common;

namespace MauiApp1.Converters
{
    public class EnumToImagePathConverter : IValueConverter
    {
        const string DOG_PATH = "Resources/Images/dog.jpg";
        const string CAT_PATH = "Resources/Images/cat.jpg";

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (AnimalImageType)value switch
            {
                AnimalImageType.Dog => DOG_PATH,
                AnimalImageType.Cat => CAT_PATH,
                _ => null,
            };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (string)value switch
            {
                DOG_PATH => AnimalImageType.Dog,
                CAT_PATH => AnimalImageType.Cat,
                _ => null,
            };
        }
    }
}
