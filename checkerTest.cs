using Xunit;

namespace SimpleMonitor.Test
{
    public class CheckerTest
    {
        [Fact]
        public void AllVitalsWithinRangeTest()
        {
            // Arrange
            float temperature = 98.6f;
            int pulseRate = 75;
            int spo2 = 95;

            // Act
            bool result = Checker.VitalsOk(temperature, pulseRate, spo2);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TemperatureOutOfRangeTest()
        {
            // Arrange
            float temperature = 103.0f; // Out of range
            int pulseRate = 75;
            int spo2 = 95;

            // Act
            bool result = Checker.VitalsOk(temperature, pulseRate, spo2);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void PulseRateOutOfRangeTest()
        {
            // Arrange
            float temperature = 98.6f;
            int pulseRate = 120; // Out of range
            int spo2 = 95;

            // Act
            bool result = Checker.VitalsOk(temperature, pulseRate, spo2);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Spo2OutOfRangeTest()
        {
            // Arrange
            float temperature = 98.6f;
            int pulseRate = 75;
            int spo2 = 85; // Out of range

            // Act
            bool result = Checker.VitalsOk(temperature, pulseRate, spo2);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void MultipleVitalsOutOfRangeTest()
        {
            // Arrange
            float temperature = 104.0f; // Out of range
            int pulseRate = 120; // Out of range
            int spo2 = 85; // Out of range

            // Act
            bool result = Checker.VitalsOk(temperature, pulseRate, spo2);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TemperatureLowerBoundaryTest()
        {
            // Arrange
            float temperature = 95.0f; // Lower boundary
            int pulseRate = 75;
            int spo2 = 95;

            // Act
            bool result = Checker.VitalsOk(temperature, pulseRate, spo2);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TemperatureUpperBoundaryTest()
        {
            // Arrange
            float temperature = 102.0f; // Upper boundary
            int pulseRate = 75;
            int spo2 = 95;

            // Act
            bool result = Checker.VitalsOk(temperature, pulseRate, spo2);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void PulseRateLowerBoundaryTest()
        {
            // Arrange
            float temperature = 98.6f;
            int pulseRate = 60; // Lower boundary
            int spo2 = 95;

            // Act
            bool result = Checker.VitalsOk(temperature, pulseRate, spo2);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void PulseRateUpperBoundaryTest()
        {
            // Arrange
            float temperature = 98.6f;
            int pulseRate = 100; // Upper boundary
            int spo2 = 95;

            // Act
            bool result = Checker.VitalsOk(temperature, pulseRate, spo2);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Spo2LowerBoundaryTest()
        {
            // Arrange
            float temperature = 98.6f;
            int pulseRate = 75;
            int spo2 = 90; // Lower boundary

            // Act
            bool result = Checker.VitalsOk(temperature, pulseRate, spo2);

            // Assert
            Assert.True(result);
        }
    }
}
