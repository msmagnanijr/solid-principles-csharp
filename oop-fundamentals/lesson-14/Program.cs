namespace Lesson14
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savingsAccount = new SavingsAccount(12345, 1000, 0.11);
            savingsAccount.CalculateInterest();
            Console.WriteLine(savingsAccount.AccountBalance);
            savingsAccount.Deposit(500);
            savingsAccount.Withdraw(100);
            //Console.WriteLine(savingsAccount.AccountBalance);
        }
    }
}
