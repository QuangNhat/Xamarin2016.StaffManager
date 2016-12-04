using System;
using System.Globalization;
using Cirrious.CrossCore.Converters;

namespace StaffManager.Core.Converters
{
	public class SexConverter
		: MvxValueConverter<bool>
	{
		protected override object Convert(bool value, Type targetType, object parameter, CultureInfo culture)
		{
			return string.Format("Sex: {0}", (true == value) ? "man" : "woman" );
		}
	}
}
