namespace Vitals
{
    // SPO2 check
    class Spo2 : IVital
    {
        private readonly int _spo2;

        public Spo2(int spo2)
        {
            _spo2 = spo2;
        }

        public bool IsOk()
        {
            return _spo2 >= 90;
        }

        public string GetAlertMessage()
        {
            return "Oxygen Saturation out of range!";
        }
    }
}

