namespace UpcastingDowncasting.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        //construtores
        public BusinessAccount() { }
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        // Métodos
        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}