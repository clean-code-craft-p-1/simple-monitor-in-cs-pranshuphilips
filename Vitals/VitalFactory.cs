namespace Vitals
{
    class VitalFactory
    {
        public static IEnumerable<IVital> CreateVitals(float temperature, int pulseRate, int spo2)
        {
            return new List<IVital>
            {
                new Temperature(temperature),
                new PulseRate(pulseRate),
                new Spo2(spo2)
            };
        }
    }
}
