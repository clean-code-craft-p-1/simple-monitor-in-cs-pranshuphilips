using Vitals;

namespace SimpleMonitor
{
    // Checker class
    class Checker
    {
        public static bool VitalsOk(float temperature, int pulseRate, int spo2)
        {
            var vitals = VitalFactory.CreateVitals(temperature, pulseRate, spo2);

            foreach (var vital in vitals)
            {
                if (!vital.IsOk())
                {
                    DisplayAlert(vital.GetAlertMessage());
                    return false;
                }
            }

            Console.WriteLine("Vitals received within normal range");
            Console.WriteLine("Temperature: {0} Pulse: {1}, SO2: {2}", temperature, pulseRate, spo2);
            return true;
        }

        public static void DisplayAlert(string message)
        {
            Console.WriteLine(message);
            for (int i = 0; i < 6; i++)
            {
                Console.Write("\r* ");
                Thread.Sleep(1000);
                Console.Write("\r *");
                Thread.Sleep(1000);
            }
        }
    }
}

