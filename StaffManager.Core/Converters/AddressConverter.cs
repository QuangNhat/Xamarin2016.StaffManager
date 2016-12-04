using System;
using System.Globalization;
using Cirrious.CrossCore.Converters;

namespace StaffManager.Core.Converters
{
	public class AddressConverter
		: MvxValueConverter<string>
	{
		protected override object Convert(string value, Type targetType, object parameter, CultureInfo culture)
		{
			return string.Format("Address: {0}", value);
		}
	}
}
