using System;
using System.Globalization;
using Cirrious.CrossCore.Converters;
using StaffManager.Core.Services.DataStore;

namespace StaffManager.Core.Converters
{
    public class ItemLocationValueConverter
        : MvxValueConverter<Staff>
    {
        protected override object Convert(Staff value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!value.LocationKnown)
                return "unknown";

            return string.Format("({0:0.0000}, {1:0.0000})", value.Lat, value.Lng);
        }
    }
}