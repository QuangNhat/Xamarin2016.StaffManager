using System;
using System.Globalization;
using Cirrious.CrossCore.Converters;

namespace StaffManager.Core.Converters
{
	public class BirthDayConverter
		: MvxValueConverter<DateTime>
	{
		protected override object Convert(DateTime value, Type targetType, object parameter, CultureInfo culture)
		{
			return string.Format("Birthday: {0:dd MMMM yyyy}", value);
		}
	}
}
