namespace HW2OOpPrinciples.BankAccount
{
    public class Mortgage : Account, IDeposit
    {
        private const int individual = 6;
        private const int company = 12;

        public Mortgage(CustomerType customer, decimal balance, decimal interestrate)
            : base(customer, balance, interestrate)
        {

        }

        public override decimal CalculateInterest(int months)
        {
            decimal result = 0;
            decimal percent = this.InterestRate / 100;
            if (this.Customer == CustomerType.Individual && months > individual)
            {
                result = (months - individual) * percent;
            }

            if (this.Customer == CustomerType.Company)
            {
                if (months > company)
                {
                    result = (months - company) * percent
                        + company * (percent / 2);
                }
            }
            return result;
        }

        public void AddMoney(decimal amount)
        {
            this.Balance += amount;
        }
    }
}
