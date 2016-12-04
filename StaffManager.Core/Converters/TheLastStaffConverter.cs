using System;
using System.Globalization;
using Cirrious.CrossCore.Converters;

namespace StaffManager.Core.Converters
{
	public class TheLastStaffConverter
	: MvxValueConverter<string>
	{
		protected override object Convert(string value, Type targetType, object parameter, CultureInfo culture)
		{
			return string.Format("The last staff: {0}", value);
		}
	}
}
