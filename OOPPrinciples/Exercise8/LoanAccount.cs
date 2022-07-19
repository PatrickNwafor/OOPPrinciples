using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples.Exercise8
{
    internal class LoanAccount : IAccount
    {
        public Customer Customer { get; set; }
        public decimal Balance { get; set; }
        public double InterestRate { get; set; }

        public LoanAccount(Customer customer, decimal balance, double interestRate)
        {
            Customer = customer;
            Balance = balance;
            InterestRate = interestRate;
        }

        public double CalculateInterest(int numberOfMonths)
        {
            double interest = 0;

            switch (Customer)
            {
                case Customer.Company:
                    interest = numberOfMonths > 2 ? this.InterestRate * (numberOfMonths - 2) : 0;
                    break;
                case Customer.Individual:
                    interest = numberOfMonths > 3 ? this.InterestRate * (numberOfMonths - 3) : 0;
                    break;
                default:
                    break;
            }

            return interest;
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }
    }
}
