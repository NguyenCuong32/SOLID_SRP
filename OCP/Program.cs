using OCP;

internal class Program
{
    private static void Main(string[] args)
    {
        CheckingAccount checkingAccount = new CheckingAccount();
        var balance = checkingAccount.CalculateBalance(new Account()
        {
            Balance = 1000,
            NumberAccount = "123456"
        });
        System.Console.WriteLine($"Your balance {balance}");
    }
}