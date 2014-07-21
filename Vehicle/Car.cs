using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Car:Vehicle
    {
        public Car(double x, double y, int cost, int speed, int year)
            : base(x, y, cost, speed, year)
        {

        }
    }
}
