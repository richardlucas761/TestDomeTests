using AlertService;
using FluentAssertions;
using Moq;

namespace AlertServiceTests
{
    public class AlertServiceTest
    {
        private readonly Mock<IAlertDao> _alertDaoMock = new();

        private readonly AlertService.AlertService alertService;

        private readonly Guid Guid1 = Guid.NewGuid();
        private readonly Guid Guid2 = Guid.NewGuid();

        private readonly DateTime AlertTime = DateTime.UtcNow.AddDays(-1);

        public AlertServiceTest()
        {
            alertService = new AlertService.AlertService(_alertDaoMock.Object);
        }

        [TestCase]
        public void RaiseAlert()
        {
            // Arrange
            _alertDaoMock.Setup(x => x.AddAlert(It.IsAny<DateTime>())).Returns(Guid1);

            // Act
            var response = alertService.RaiseAlert();

            // Assert
            response.Should().Be(Guid1);
            _alertDaoMock.Verify(x => x.AddAlert(It.IsAny<DateTime>()), Times.Once);
        }

        [TestCase]
        public void GetAlertTime()
        {
            // Arrange
            _alertDaoMock.Setup(x => x.GetAlert(Guid2)).Returns(AlertTime);

            // Act
            var response = alertService.GetAlertTime(Guid2);

            // Assert
            response.Should().Be(AlertTime);
            _alertDaoMock.Verify(x => x.GetAlert(Guid2), Times.Once);
        }
    }
}
