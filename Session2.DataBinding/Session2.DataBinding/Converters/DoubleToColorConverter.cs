using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Session2.DataBinding.Converters
{
    public class DoubleToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double p = 10;//default value

            if (parameter != null)
            {
                p = Double.Parse(parameter.ToString());
            }                

            switch (value)
            {
                case double v when v > p:
                    return Color.GreenYellow;
                default:
                    return Color.Red;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
