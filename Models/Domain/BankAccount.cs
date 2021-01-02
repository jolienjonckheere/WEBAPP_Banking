namespace Banking.Models.Domain
{
    public class BankAccount
    {
        #region Properties
        public decimal Balance { get; private set; } = 0M;

        public string AccountNumber { get; }

        /*
        private readonly string _accountNumber;
        private decimal _balance;
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        */
        #endregion

        #region Constructor
        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
        }
        #endregion

        #region Methods
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
        #endregion
    }
}
