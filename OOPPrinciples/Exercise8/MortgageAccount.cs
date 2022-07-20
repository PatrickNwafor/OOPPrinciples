using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples.Exercise8
{
    internal class MortgageAccount : IAccount
    {
        public Customer Customer { get; set; }
        public decimal Balance { get; set; }
        public double InterestRate { get; set; }

        public MortgageAccount(Customer customer, decimal balance, double interestRate)
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
                    interest = numberOfMonths <= 12 ? 1d / 2d * this.InterestRate * numberOfMonths 
                        : this.InterestRate * numberOfMonths;
                    break;
                case Customer.Individual:
                    interest = numberOfMonths > 6 ? this.InterestRate * numberOfMonths : 0;
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
