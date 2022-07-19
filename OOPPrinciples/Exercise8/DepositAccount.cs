namespace OOPPrinciples.Exercise8
{
    internal class DepositAccount : IAccount
    {
        public Customer Customer { get; set; }
        public decimal Balance { get; set; }
        public double InterestRate { get; set; }

        public DepositAccount(Customer customer, decimal balance, double interestRate)
        {
            Customer = customer;
            Balance = balance;
            InterestRate = interestRate;
        }

        public double CalculateInterest(int numberOfMonths)
        {
            double interest = 0;
            if(this.Balance > 1000m)
            {
                switch (Customer)
                {
                    case Customer.Company:
                    case Customer.Individual:
                        interest = this.InterestRate * numberOfMonths;
                        break;
                    default:
                        break;
                }

                return interest;
            }
            else
            {
                return interest;
            }
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if(amount < this.Balance)
            {
                this.Balance -= amount;
            }
            else
            {
                throw new AccountBalanceLowException("You cannot withdraw an amount more than that in your account");
            }
        }
    }
}
