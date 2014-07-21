using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Vehicle
    {
        private double _x;
        private double _y;
        private int _cost;
        private int _speed;
        private int _productionYear;

        public Vehicle(double x, double y, int cost, int speed, int year)
        {
            this._x = x;
            this._y = y;
            this._cost = cost;
            this._speed = speed;
            this._productionYear = year;

        }
        public virtual void Print()
        {
            Console.WriteLine("Coordinates are:{0},{1}", _x, _y);
            Console.WriteLine("Cost:" + _cost + "EUR");
            Console.WriteLine("Speed:" + _speed + "km/hour");
            Console.WriteLine("Year of issue:" + _productionYear);
        }
    }
}
