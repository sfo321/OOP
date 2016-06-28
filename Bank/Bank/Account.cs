namespace HW2OOpPrinciples.BankAccount
{
    using System;

    public abstract class Account
    {
        protected CustomerType Customer { get; }
        private decimal balance;
        private decimal interestRate;

        public Account(CustomerType customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance can`t be negative!!");
                }
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Interest rate can`t be negative or bigger than 100!!");
                }
                this.interestRate = value;
            }
        }
        public abstract decimal CalculateInterest(int months);

        public override string ToString()
        {
            return string.Format("Account type: {0}, Balance: {1}, Interest Rate: {2}%"
                , GetType().Name, balance, interestRate);
        }
    }
}
