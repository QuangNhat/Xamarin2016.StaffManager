using System;
using System.Globalization;
using Cirrious.CrossCore.Converters;

namespace StaffManager.Core.Converters
{
	public class StaffNameConverter
		: MvxValueConverter<string>
	{
		protected override object Convert(string value, Type targetType, Object parameter, CultureInfo culture)
		{
			return string.Format("Name: {0}", value);
		}
	}
}
