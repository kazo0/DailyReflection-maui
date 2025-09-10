﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;


namespace DailyReflection.Converters;

public class HasValueConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return value != null;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}
