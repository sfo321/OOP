namespace HW2OOpPrinciples.BankAccount
{
    public class Deposit : Account, IDeposit, IWithdraw
    {
        public Deposit(CustomerType customer, decimal balance, decimal interest)
            : base(customer, balance, interest)
        {
        }

        public void AddMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public override decimal CalculateInterest(int months)
        {
            decimal result = 0;

            if (this.Balance > 1000)
            {
                result = months * (this.InterestRate / 100);
            }
            return result;
        }

        public void GetMoney(decimal amount)
        {
            if (this.Balance < amount)
            {
                this.Balance = 0;
            }
            else
            {
                this.Balance -= amount;
            }
        }
    }
}
