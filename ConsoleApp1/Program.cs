using ConsoleApp1;
using System;
class Program
{
    static void Main(string[] args)
    {
        IDevice lamp = new Lamp(State.Off);

        Switch lampSwitch = new Switch(lamp);

        lampSwitch.Press();  
        lampSwitch.Press(); 
    }
}
