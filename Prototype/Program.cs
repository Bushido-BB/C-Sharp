using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] cars = {"Bugatti", "Saleen", "Pagani"};
            Console.WriteLine("Hello " + showName());
        }
        static string showName()
        {
            return Console.ReadLine();
        }
    }
}