using UpcastingDowncasting.Entities;

namespace UpcastingDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Ricardo", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Karen", 0.0, 500.0);

            // Upcasting (Conversão de subclasse para superclasse)
            // business account É UM account
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Alice", 0.0, 200.00);
            Account acc3 = new SavingsAccount(1004, "Aurora", 0.0, 0.01);

            // Downcasting (Conversão de superclasse para subclasse ) usar somente quando necessário
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            //BusinessAccount acc5 = acc3;
            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount; // sintaxe alternativa
                acc5.UpdateBalance();
                Console.WriteLine("Update");
            }
        }
    }
}