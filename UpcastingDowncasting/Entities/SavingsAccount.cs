namespace UpcastingDowncasting.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        // construtores
        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}