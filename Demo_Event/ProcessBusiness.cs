using System;

namespace Demo_Event;
public delegate void Notify();
public class ProcessBusiness
{
    public event Notify OnProcess;
    public void Process(){
        System.Console.WriteLine("Start");
        System.Console.WriteLine("Do something ....");
        System.Threading.Thread.Sleep(5000);
        Completing();
    } 
    public void Completing(){
        OnProcess?.Invoke();
    }
}
