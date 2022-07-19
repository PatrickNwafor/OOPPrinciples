namespace OOPPrinciples.Exercise8
{
    internal interface IAccount
    {
        /// <summary>
        /// Customer type, either individual or company
        /// </summary>
        Customer Customer { get; set; }
        /// <summary>
        /// Current account balance
        /// </summary>
        decimal Balance { get; set; }
        /// <summary>
        /// Monthly based Interest Rate
        /// </summary>
        double InterestRate { get; set; }
        /// <summary>
        /// Calculates interest rate of an account across a time frame
        /// </summary>
        /// /// <param name="numberOfMonths">
        /// Number of months to calculate interest
        /// </param>
        /// <returns> Interest on account</returns>
        double CalculateInterest(int numberOfMonths);
        /// <summary>
        /// Deposit Money into account
        /// </summary>
        /// <param name="amount">
        /// Amount to deposit
        /// </param>
        void Deposit(decimal amount);
    }
}
