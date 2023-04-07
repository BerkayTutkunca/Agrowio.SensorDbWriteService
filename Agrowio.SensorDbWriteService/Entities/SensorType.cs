using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Agrowio.Common.Models.Enums
{
    public static class SensorType
    {
        public static string InternalTemperature { get; } = "İç Sıcaklık";
        public static string OutsideTemperature { get; } = "Dış Sıcaklık";
        public static string InternalHumidity { get; } = "İç Nem";
        public static string Pressure { get; } = "Basınç";
        public static string WindSpeed { get; } = "Rüzgar Hız";
        public static string WindDirection { get; } = "Rüzgar Yön";
        public static string FlowMeter { get; } = "Debimetre";
        public static string Ec { get; } = "Ec";
        public static string Ph { get; } = "Ph";
        public static string Rain { get; } = "Yağmur";
        public static string SolarRadiation { get; } = "Solar Radyasyon";
        public static string CarbonDioxide { get; } = "Karbondioksit";
        public static string Tank { get; } = "Depo";
        public static string Other { get; } = "Diğer";

    }
}
