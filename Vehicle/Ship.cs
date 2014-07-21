using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Ship:Vehicle
    {
        private int _passengersQty;
        private string _port;

        public Ship(double x, double y, int cost, int speed, int year, int psngr, string port)
            : base(x, y, cost, speed, year)
        {
            this._passengersQty = psngr;
            this._port = port;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Max passengers quantity:{0}", _passengersQty);
            Console.WriteLine("Port of assignment:" + _port);
        }
    }
}
