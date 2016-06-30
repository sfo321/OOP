using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2OOpPrinciples.BankAccount
{
    class BankStart
    {
        static void Main()
        {
            var deposit = new Deposit(CustomerType.Company, 150000, 8);
            var loan = new Loan(CustomerType.Individual, 1500, 9);
            var mortgage = new Mortgage(CustomerType.Individual, 12000, 6);

            Console.WriteLine(deposit);
            Console.WriteLine(loan);
            Console.WriteLine(mortgage);

            loan.AddMoney(1500);
            deposit.GetMoney(20000);
            mortgage.AddMoney(250);

            Console.WriteLine(deposit);
            Console.WriteLine(loan);
            Console.WriteLine(mortgage);
        }
    }
}
