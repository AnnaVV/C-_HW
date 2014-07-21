using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Plane: Vehicle
    {
        private int _height;
        private int _passengersQty;

        public Plane(int h, int qty, double x, double y, int cost, int speed, int year)
             :base(x,y,cost,speed,year)
        {
            this._height = h;
            this._passengersQty = qty;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Plane height is{0} km", _height);
            Console.WriteLine("Max passengers quantity:" + _passengersQty);
            Console.WriteLine("_________________________________");
        }
    }
}
