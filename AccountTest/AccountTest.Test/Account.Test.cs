namespace AccountTest.Test
{
    [TestFixture]
    public class Tester
    {
        private readonly double epsilon = 1e-6;

        [Test]
        public void AccountCannotHaveNegativeOverdraftLimit()
        {
            Account account = new(-20);

            Assert.That(account.OverDraftLimit, Is.Zero);
        }

        [Test]
        public void DepositMethodWillNotAcceptNegativeNumbers()
        {
            var account = new Account(-100);

            // TODO
        }
    }
}