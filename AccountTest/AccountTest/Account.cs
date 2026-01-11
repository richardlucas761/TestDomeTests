namespace AccountTest
{
    public class Account(double overDraftLimit)
    {
        public double OverDraftLimit { get; set; } = overDraftLimit > 0 ? overDraftLimit : 0;

        public double Balance { get; set; }

        public bool Deposit(double amount)
        {
            if (amount >= 0)
            {
                Balance += amount;
                return true;
            }

            return false;
        }

        public bool Withdraw(double amount)
        {
            if (Balance - amount >= overDraftLimit && amount >= 0)
            {
                Balance = amount;
                return true;
            }
            return false;
        }
    }
}
