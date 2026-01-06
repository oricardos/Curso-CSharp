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

        public override void Withdraw(double amount)
        {
            // Sobrescrevendo o modo como o método funciona,
            // nesse caso não é descontado nada
            //Balance -= amount;

            // nesse caso o saque ocorre como na superclasse
            // valor mais 5
            base.Withdraw(amount);
            // e agora desconta + 2 do valor
            Balance -= 2.0;
        }
    }
}