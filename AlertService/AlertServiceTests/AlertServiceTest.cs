using AlertService;
using Moq;

namespace AlertServiceTests
{
    public class AlertServiceTest
    {
        //private readonly IAlertDao alertDao = new Mock<IAlertDao>();

        private readonly AlertService.AlertService alertService;

        public AlertServiceTest(IAlertDao alertDao)
        {
            //alertService = new AlertService.AlertService(alertDao.Object());
        }

        [TestCase]
        public void RaiseAlert()
        {
            // Arrange

            // Act
            alertService.RaiseAlert();

            // Assert
        }
    }
}
