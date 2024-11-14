using Delegate_Event;

internal class Program
{
    // Định nghĩa delegate
    private delegate void Callback(string message);
    private delegate void AnimalCallback(string food);
    private static void Main(string[] args)
    {
        Console.WriteLine("Delegate Demo");
        // Gan, tao instance
        Callback callback = ShowInformation;
        callback.Invoke("Insert done");//c1
        callback("Start new insert"); //c2
        Animal animal = new Animal();
        AnimalCallback animalcallback = animal.Eat;
        animalcallback.Invoke("Meat");
        animalcallback("Vegatable");
    }
    private static void ShowInformation(string message){
        System.Console.WriteLine(message);
    }
}