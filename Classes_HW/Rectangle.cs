﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_HW
{
    class Rectangle
    {
        double side1, side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        private double AreaCalculator()
        { 
            return side1*side2;
        }

        private double PerimeterCalculator()
        { 
           return 2*(side1 + side2);
        }

        public double Area
        {
            get
            {
                return this.AreaCalculator();
            }
        }

        public double Perimeter
        {
            get
            {
                return this.PerimeterCalculator();
            }
        }
    }
}
