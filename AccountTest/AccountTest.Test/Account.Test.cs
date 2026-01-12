using FluentAssertions;

namespace AccountTest.Test
{
    [TestFixture]
    public class Tester
    {
        [Test]
        public void DepositAndWithdrawGiveCorrectBalance()
        {
            // Arrange
            const double depositAmount = 150.50;
            const double withdrawlAmount = 50.15;

            Account account = new(5000);

            // Act
            // Assert
            account.Balance.Should().Be(0);

            var deposit = account.Deposit(depositAmount);

            deposit.Should().BeTrue();

            account.Balance.Should().Be(depositAmount);

            var withdrawl = account.Withdraw(withdrawlAmount);

            withdrawl.Should().BeTrue();

            account.Balance.Should().Be(depositAmount - withdrawlAmount);

            account.OverDraftLimit.Should().Be(5000);
        }

        [Test]
        [TestCase(100, -101, false)]
        [TestCase(300.30, 300.29, true)]
        [TestCase(400.40, 400.40, true)]
        [TestCase(500, 500.000000001, false)]
        public void AccountCannotOverstepItsOverdraftLimitWhenWithdrawing(double overdraftLimit, double withdrawl,
            bool expectedResult)
        {
            // Arrange
            Account account = new(overdraftLimit);

            // Act
            var result = account.Withdraw(withdrawl);

            // Assert
            result.Should().Be(expectedResult);
        }

        [Test]
        [TestCase(0)]
        [TestCase(100)]
        [TestCase(500.33)]
        [TestCase(double.MaxValue)]
        public void AccountAcceptsValidOverdraftLimit(double overdraftLimit)
        {
            // Arrange

            // Act
            Account account = new(overdraftLimit);

            // Assert
            account.OverDraftLimit.Should().Be(overdraftLimit);
        }

        [Test]
        [TestCase(-20)]
        [TestCase(-555.55)]
        [TestCase(-0)]
        [TestCase(double.MinValue)]
        public void AccountCannotHaveInvalidOverdraftLimit(double overdraftLimit)
        {
            // Arrange

            // Act
            Account account = new(overdraftLimit);

            // Assert
            account.OverDraftLimit.Should().Be(0);
        }

        [Test]
        [TestCase(100, -46)]
        [TestCase(1, 0)]
        public void DepositMethodWillNotAcceptInvalidNumbers(double overdraftLimit, double deposit)
        {
            // Arrange
            var account = new Account(overdraftLimit);

            account.OverDraftLimit.Should().Be(overdraftLimit);

            // Act 
            var result = account.Deposit(deposit);

            // Assert
            result.Should().BeFalse();
        }

        [Test]
        [TestCase(555.55, -1.43)]
        [TestCase(777.33, 0)]
        public void WithdrawMethodWillNotAcceptInvalidNumbers(double overdraftLimit, double withdrawl)
        {
            // Arrange
            var account = new Account(overdraftLimit);

            account.OverDraftLimit.Should().Be(overdraftLimit);

            // Act
            var result = account.Withdraw(withdrawl);

            // Assert
            result.Should().BeFalse();
        }
    }
}
