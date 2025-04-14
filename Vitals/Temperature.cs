namespace Vitals
{
    // Temperature check
    class Temperature : IVital
    {
        private readonly float _temperature;

        public Temperature(float temperature)
        {
            _temperature = temperature;
        }

        public bool IsOk()
        {
            return _temperature >= 95 && _temperature <= 102;
        }

        public string GetAlertMessage()
        {
            return "Temperature critical!";
        }
    }
}
