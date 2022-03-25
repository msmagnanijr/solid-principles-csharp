namespace Lesson14
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount(int accountNumber, double accountBalance, double interestRate) : base(accountNumber, accountBalance)
        {
            InterestRate = interestRate;
            System.Console.WriteLine("Log from SavingsAccount constructor\n");
        }

        public void CalculateInterest()
        {
            AccountBalance += AccountBalance * InterestRate;
            System.Console.WriteLine("Interest added");
            System.Console.WriteLine("Log from SavingsAccount.CalculateInterest\n");
        }

        public override void Deposit(double amount)
        {
            AccountBalance += amount;
            System.Console.WriteLine($"Deposit of {amount} made. New balance is {AccountBalance}");
            System.Console.WriteLine("Log from SavingsAccount.Deposit\n");
        }

        public new void Withdraw(double amount)
        {
            AccountBalance -= amount;
            System.Console.WriteLine($"Withdrawal of {amount} made. New balance is {AccountBalance}");
            System.Console.WriteLine("Log from SavingsAccount.Withdraw\n");
        }
    }
}