using DIP;

internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Start");
        DataAccessLayer data = new DataAccessLayer(new FileLogger());
        data.AddCustomer("Hoang Anh");
        System.Console.WriteLine("End");
    }
}