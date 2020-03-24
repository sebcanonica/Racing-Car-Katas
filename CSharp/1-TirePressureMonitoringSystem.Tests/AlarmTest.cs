
using FluentAssertions;
using Xunit;

namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class AlarmTest
    {
        [Fact]
        public void Nominal()
        {
            Alarm alarm = new Alarm(new FakeSensor(17));
            alarm.Check();
            alarm.AlarmOn.Should().BeFalse();
        }

        [Fact]
        public void Error()
        {
            Alarm alarm = new Alarm(new FakeSensor(40));
            alarm.Check();
            alarm.AlarmOn.Should().BeTrue();
        }

        class FakeSensor : ISensor
        {
            private int v;

            public FakeSensor(int v)
            {
                this.v = v;
            }

            public double PopNextPressurePsiValue()
            {
                return v;
            }
        }
    }
}