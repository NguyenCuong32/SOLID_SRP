using Demo_Event;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Demo Event");
        ProcessBusiness process = new ProcessBusiness();
        process.OnProcess += ProcessBusiness_OnProcess;
        process.Process();
    }
    private static void ProcessBusiness_OnProcess(){
        System.Console.WriteLine("Completed");
    }
}