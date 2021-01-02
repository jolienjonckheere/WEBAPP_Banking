using System;
using System.Collections.Generic;

namespace Banking.Models.Domain
{
    public class BankAccount
    {
        private readonly IList<Transaction> _transactions;

        #region Properties
        public decimal Balance { get; private set; } = 0M;

        public string AccountNumber { get; }

        public int NumberOfTransactions { get { return _transactions.Count; } }

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
            _transactions = new List<Transaction>();
        }
        #endregion

        #region Methods
        public void Deposit(decimal amount)
        {
            Balance += amount;
            _transactions.Add(new Transaction(amount, TransactionType.Deposit));
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
            _transactions.Add(new Transaction(amount, TransactionType.Withdraw));
        }

        //return all transaties binnen interval
        public IEnumerable<Transaction> GetTransactions(DateTime? from, DateTime? till)
        {
            if (from == null && till == null) return _transactions;
            if (from == null) from = DateTime.MinValue;
            if (till == null) till = DateTime.MaxValue;

            IList<Transaction> result = new List<Transaction>();
            foreach (Transaction item in _transactions)
            {
                //check voor elke transactie of de datum ligt tussen from en till
                //zoja toevoegen aan lijst
                if (from <= item.DateOfTrans && till >= item.DateOfTrans)
                {
                    result.Add(item);
                }
            }
            return result;
        }
        #endregion
    }
}
