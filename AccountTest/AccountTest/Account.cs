namespace AccountTest
{
    /// <summary>
    /// Create a new Account.
    /// </summary>
    /// <param name="overDraftLimit">An overdraft limit.</param>
    public class Account(double overDraftLimit)
    {
        /// <summary>
        /// Overdraft limit for this account.
        /// </summary>
        /// <remarks>If an overdraft limit of less than 0 is specified this will be set to 0.</remarks>
        public double OverDraftLimit { get; private set; } = overDraftLimit > 0 ? overDraftLimit : 0;

        /// <summary>
        /// Current balance for this account.
        /// </summary>
        public double Balance { get; set; }

        /// <summary>
        /// Deposit an amount of money into an account.
        /// </summary>
        /// <param name="amount">An amount of money to deposit.</param>
        /// <returns>If the deposit is successful true is returned, false otherwise.</returns>
        public bool Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Withdraw an amount of money from an account.
        /// </summary>
        /// <param name="amount">An amount of money to withdraw.</param>
        /// <returns>If the withdrawl is successful, false otherwise if the amount is invalid or the withdrawl would exceed the 
        /// overdraft limit.</returns>
        public bool Withdraw(double amount)
        {
            if (Balance - amount >= -overDraftLimit && amount > 0)
            {
                Balance = -amount;
                return true;
            }
            return false;
        }
    }
}
