
using FluentAssertions;
using Xunit;

namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class AlarmTest
    {
        [Fact]
        public void Foo()
        {
            Alarm alarm = new Alarm();
            alarm.AlarmOn.Should().BeFalse();
        }
    }
}