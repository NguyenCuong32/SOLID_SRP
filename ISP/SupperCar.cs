using System;

namespace ISP;

public class SupperCar : IDriver, IFlying
{
    public void Driver()
    {
        System.Console.WriteLine("The car drive");
    }

    public void Flying()
    {
       System.Console.WriteLine("The car can flying");
    }
}
