
using FluentAssertions;
using Xunit;

namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class AlarmTest
    {
        [Fact]
        public void Nominal()
        {
            Alarm alarm = new TestableAlarm(17);
            alarm.Check();
            alarm.AlarmOn.Should().BeFalse();
        }

        [Fact]
        public void Error()
        {
            Alarm alarm = new TestableAlarm(40);
            alarm.Check();
            alarm.AlarmOn.Should().BeTrue();
        }

        class TestableAlarm : Alarm
        {
            private int v;

            public TestableAlarm(int v)
            {
                this.v = v;
            }

            protected override double GetPsiPressureValue()
            {
                return v;
            }
        }
    }
}