using POC_Flunt.Entities;
using System;
using System.Linq;

namespace POC_Flunt
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("ttt", "olá", true);
            car.Update("", true);

            Console.WriteLine("Hello World!");
        }
    }
}
