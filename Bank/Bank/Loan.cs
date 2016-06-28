namespace HW2OOpPrinciples.BankAccount
{
    public class Loan : Account, IDeposit
    {
        private const int individual = 3;
        private const int company = 2;

        public Loan(CustomerType customer, decimal balance, decimal interest)
            : base(customer, balance, interest)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            decimal result = 0;

            if (this.Customer == CustomerType.Individual && months > individual)
            {
                result = (months - individual) * (this.InterestRate / 100);
            }
            if (this.Customer == CustomerType.Company && months > company)
            {
                result = (months - company) * (this.InterestRate / 100);
            }
            return result;
        }

        public void AddMoney(decimal amount)
        {
            this.Balance += amount;
        }
    }
}
