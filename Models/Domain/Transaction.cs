using System;

namespace Banking.Models.Domain
{
    public class Transaction
    {
        #region Properties
        public decimal Amount { get; }
        public DateTime DateOfTrans { get; }
        //TransactionType (enum)
        public TransactionType TransactionType { get; set; }
        public bool IsWithdraw { get { return TransactionType == TransactionType.Withdraw; } }
        #endregion

        public Transaction(decimal amount, TransactionType type)
        {
            Amount = amount;
            TransactionType = type;
            DateOfTrans = DateTime.Now;
        }
    }
}
