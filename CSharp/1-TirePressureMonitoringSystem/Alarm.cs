namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class Alarm
    {
        private const double LowPressureThreshold = 17;
        private const double HighPressureThreshold = 21;

        Sensor _sensor = new Sensor();

        bool _alarmOn = false;

        public void Check()
        {
            double psiPressureValue = GetPsiPressureValue();

            if (psiPressureValue < LowPressureThreshold || HighPressureThreshold < psiPressureValue)
            {
                _alarmOn = true;

            }
        }

        protected virtual double GetPsiPressureValue()
        {
            return _sensor.PopNextPressurePsiValue();
        }

        public bool AlarmOn
        {
            get { return _alarmOn; }
        }

    }
}
