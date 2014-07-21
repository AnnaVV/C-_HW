using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Figure
{
    class Point
    {
        private string _pointName;
        private int _x;
        private int _y;

        public string PointName
        {
            get
            {
                return _pointName;
            }
        }

        public int X
        {
            get 
            {
                return _x;
            }
        }

        public int Y
        {
            get 
            {
                return _y;
            }
        }

        public Point(string name, int x, int y)
        {
            this._pointName = name;
            this._x = x;
            this._y = y;
        }

    }
}
