using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace Aerodrom.ViewModel.Helper
{
    class BooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, String s)
        {
            if (value is Boolean && !(bool)value)
            {
                return Visibility.Visible;
            }
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, String s)
        {
            if (value is Visibility && (Visibility)value == Visibility.Collapsed)
            {
                return true;
            }
            return false;
        }
    }
}
