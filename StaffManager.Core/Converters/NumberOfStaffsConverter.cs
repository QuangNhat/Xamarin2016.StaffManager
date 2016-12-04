using System;
using System.Globalization;
using Cirrious.CrossCore.Converters;

namespace StaffManager.Core.Converters
{
	public class NumberOfStaffsConverter
	: MvxValueConverter<int>
	{
		protected override object Convert(int value, Type targetType, object parameter, CultureInfo culture)
		{
			return string.Format("Number of Staffs: {0}", value);
		}
	}
}
