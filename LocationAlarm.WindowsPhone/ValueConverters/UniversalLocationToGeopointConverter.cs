﻿using System;
using Windows.Devices.Geolocation;
using Windows.UI.Xaml.Data;

namespace LocationAlarm.WindowsPhone.ValueConverters
{
    public class UniversalLocationToGeopointConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var tuple = value as Tuple<double, double>;
            return tuple == null
                ? null
                : new Geopoint(new BasicGeoposition {Latitude = tuple.Item1, Longitude = tuple.Item2});
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}