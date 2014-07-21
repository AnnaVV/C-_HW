using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car1 = new Car(30, 30, 30000, 240, 2012);
            car1.Print();

            Vehicle ship1 = new Ship(10, 50, 20000, 130, 2013, 250, "Barcelona");
            ship1.Print();

            Vehicle plane1 = new Plane(7000, 200, 50, 70, 40000, 800, 2000);
            plane1.Print();

            Console.ReadLine();
        }
    }
}
