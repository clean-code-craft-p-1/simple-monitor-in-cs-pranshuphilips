using Xunit;

namespace SimpleMonitor.Test
{
    public class CheckerTest
    {
        [Theory]
        [InlineData(98.6f, 75, 95, true)]  // All vitals within range
        [InlineData(103.0f, 75, 95, false)] // Temperature out of range
        [InlineData(98.6f, 120, 95, false)] // Pulse rate out of range
        [InlineData(98.6f, 75, 85, false)]  // SPO2 out of range
        [InlineData(104.0f, 120, 85, false)] // Multiple vitals out of range
        [InlineData(95.0f, 75, 95, true)]   // Temperature lower boundary
        [InlineData(102.0f, 75, 95, true)]  // Temperature upper boundary
        [InlineData(98.6f, 60, 95, true)]   // Pulse rate lower boundary
        [InlineData(98.6f, 100, 95, true)]  // Pulse rate upper boundary
        [InlineData(98.6f, 75, 90, true)]   // SPO2 lower boundary
        public void VitalsOkTest(float temperature, int pulseRate, int spo2, bool expectedResult)
        {
            // Act
            bool result = Checker.VitalsOk(temperature, pulseRate, spo2);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
