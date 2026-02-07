using FluentAssertions;

namespace GamePlatformTests
{
    /// <summary>
    /// Tests for <see cref="GamePlatform"/>
    /// </summary>
    [TestClass]
    public sealed class CalculateFinalSpeedTest
    {
        [TestMethod]
        public void CalculateFinalSpeedReturnsExpectedValue()
        {
            // Arrange

            // Act
            var result = GamePlatform.GamePlatform.CalculateFinalSpeed(60, [0, 30, 0, -45, 0]);

            // Assert
            result.Should().Be(75);
        }

        [TestMethod]
        public void CalculateFinalSpeedReturnsZeroWhenDeclinationMakesCharacterLoseALife()
        {
            // Arrange

            // Act
            var result = GamePlatform.GamePlatform.CalculateFinalSpeed(5, [-20, 30, 0, -45, 0]);

            // Assert
            result.Should().Be(0);
        }

        [TestMethod]
        public void CalculateFinalSpeedThrowsExceptionIfAngleIs90()
        {
            // Arrange

            // Act
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                GamePlatform.GamePlatform.CalculateFinalSpeed(22, [1, 89, -11, -3, 90]));
        }

        [TestMethod]
        public void CalculateFinalSpeedThrowsExceptionIfAngleIsMinus90()
        {
            // Arrange

            // Act
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                GamePlatform.GamePlatform.CalculateFinalSpeed(100, [1, 13, -11, -3, 44, -90]));
        }

        [TestMethod]
        public void CalculateFinalSpeedThrowsExceptionIfAngleIsGreaterThan90()
        {
            // Arrange

            // Act
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                GamePlatform.GamePlatform.CalculateFinalSpeed(22, [1, 1, -3, 91, 89, 92]));
        }

        [TestMethod]
        public void CalculateFinalSpeedThrowsExceptionIfAngleIsLessThanMinus90()
        {
            // Arrange

            // Act
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                GamePlatform.GamePlatform.CalculateFinalSpeed(33, [1, 44, -3, -91, -89, -92]));
        }
    }
}
