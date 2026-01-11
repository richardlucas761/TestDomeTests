using FluentAssertions;

namespace AccountTest.Test
{
    [TestFixture]
    public class Tester
    {
        [Test]
        public void AccountCannotHaveNegativeOverdraftLimit()
        {
            // Arrange

            // Act
            Account account = new(-20);

            // Assert
            account.OverDraftLimit.Should().Be(0);
        }

        [Test]
        public void DepositMethodWillNotAcceptNegativeNumbers()
        {
            // Arrange
            const double overdraftLimit = 100;

            var account = new Account(overdraftLimit);

            account.OverDraftLimit.Should().Be(overdraftLimit);

            // Act 
            var result = account.Deposit(-46);

            // Assert
            result.Should().BeFalse();
        }

        [Test]
        public void WithdrawMethodWillNotAcceptNegativeNumbers()
        {
            // Arrange
            const double overdraftLimit = 6577.44;

            var account = new Account(overdraftLimit);

            account.OverDraftLimit.Should().Be(overdraftLimit);

            // Act
            var result = account.Withdraw(-8.44);

            // Assert
            result.Should().BeFalse();
        }
    }
}