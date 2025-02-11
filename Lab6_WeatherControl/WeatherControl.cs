using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lab6_WeatherControl
{
    enum Rainfall
    {
        Sunny,
        Cloudy,
        Rainy,
        Snowy
    };

    class WeatherControl : DependencyObject
    {
        //* температуру(целое число в диапазоне от -50 до +50), Свойство «температура» преобразовать в свойство зависимости
        //* направление ветра(строка) + скорость ветра(целое число)
        //* наличие осадков(возможные значения: 0 – солнечно, 1 – облачно, 2 – дождь, 3 – снег.Можно использовать целочисленное значение, либо создать перечисление enum).
        private string windDirection;
        private int windSpeed;
        private Rainfall presenceOfRainfall;

        public WeatherControl(int windSp, string windDir, Rainfall presence)
        {
            this.WindDirection = windDir;
            this.windSpeed = windSp;
            this.presenceOfRainfall = presence;
        }


        public string WindDirection { get; set; }
        public int WindSpeed { get; set; }

        public static readonly DependencyProperty TempProperty;
        public int Temperature {
            get => (int)GetValue(TempProperty);
            set => SetValue(TempProperty, value);
        }

        static WeatherControl()
        {
            TempProperty = DependencyProperty.Register(
                nameof(Temperature),
                typeof(int),
                typeof(WeatherControl),
                new FrameworkPropertyMetadata(
                    15,
                    FrameworkPropertyMetadataOptions.AffectsMeasure,
                    null,
                    null),
                new ValidateValueCallback(ValidateTemperature));
        }

        private static bool ValidateTemperature(object value)
        {
            throw new NotImplementedException();
        }

        private static void TempPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
