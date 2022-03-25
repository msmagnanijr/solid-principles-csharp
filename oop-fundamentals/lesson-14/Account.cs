namespace Lesson14
{
    class Account
    {
        public Account(int accountNumber, double accountBalance)
        {
            AccountNumber = accountNumber;
            AccountBalance = accountBalance;
            System.Console.WriteLine("Log from Account constructor\n");
        }
        public int AccountNumber { get; set; }
        public double AccountBalance { get; set; }

        public virtual void Deposit(double amount)
        {
            AccountBalance += amount;
            System.Console.WriteLine($"Deposit of {amount} made. New balance is {AccountBalance}");
            System.Console.WriteLine("Log from Account.Deposit\n");
        }

        public void Withdraw(double amount)
        {
            AccountBalance -= amount;
            System.Console.WriteLine($"Withdrawal of {amount} made. New balance is {AccountBalance}");
            System.Console.WriteLine("Log from Account.Withdraw\n");
        }
    }
}
