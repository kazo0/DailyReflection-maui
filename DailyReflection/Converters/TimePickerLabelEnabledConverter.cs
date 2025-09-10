using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;


namespace DailyReflection.Converters;

public class TimePickerLabelEnabledConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (Device.RuntimePlatform == Device.Android)
		{
			return true;
		}
		return (bool)value;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}
