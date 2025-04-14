namespace Vitals
{
    // Pulse rate check
    class PulseRate : IVital
    {
        private readonly int _pulseRate;

        public PulseRate(int pulseRate)
        {
            _pulseRate = pulseRate;
        }

        public bool IsOk()
        {
            return _pulseRate >= 60 && _pulseRate <= 100;
        }

        public string GetAlertMessage()
        {
            return "Pulse Rate is out of range!";
        }
    }
}
