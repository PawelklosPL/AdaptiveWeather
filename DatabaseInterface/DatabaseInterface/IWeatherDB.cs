﻿namespace DatabaseInterface
{
    public interface IWeatherDB
    {
        void AddWeather();
        void EditWeather();
        void RemoveWeather();
        void UpdateWeather();
        void GetWeather();
    }
}
