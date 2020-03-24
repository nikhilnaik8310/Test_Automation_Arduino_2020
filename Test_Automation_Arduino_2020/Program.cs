using System;
using System.IO.Ports;

namespace Test_Automation_Arduino_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SerialPort S = new SerialPort("COM4", 9600);
            S.Open();
        }
    }
}
