using System;

namespace ISP;

public class Car : IDriver
{
    public void Driver()
    {
       System.Console.WriteLine("The car can drive");
    }
}
