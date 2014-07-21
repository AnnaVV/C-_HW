using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Figure
{
    class Figure
    {
        private string _figureName;
        private Point p1;
        private Point p2;
        private Point p3;
        private Point p4;
        private Point p5;

        public string FigureName
        {
            get { return _figureName; }
        }

        private Figure(string figureName, Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            this._figureName = figureName;
            this.p1 = point1;
            this.p2 = point2;
            this.p3 = point3;
            this.p4 = point4;
            this.p5 = point5;

        }

        public Figure(Point point1, Point point2, Point point3)
            :this("triangle",point1,point2,point3,null,null)
        {
            
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
            : this("rectangle", point1, point2, point3, point4, null)
        {
           
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
            : this("pentagon", point1, point2, point3, point4, point5)
        {
            
        }

        private double Lengthside(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow((point1.X - point2.X),2) + Math.Pow((point1.Y - point2.Y),2));
        }

        public void PerimeterCalculator()
        {
            switch (_figureName)
            {
                case "triangle":
                    Console.WriteLine("Triangle perimeter is: {0}", this.Lengthside(this.p1, this.p2) + this.Lengthside(this.p2, this.p3) + this.Lengthside(this.p3, this.p1));
                    break;

                case "rectangle":
                    Console.WriteLine("Rectangle perimeter is: {0}", this.Lengthside(this.p1, this.p2) + this.Lengthside(this.p2, this.p3) + this.Lengthside(this.p3, this.p4)+ this.Lengthside(this.p4, this.p1));
                    break;

                case "pentagon":
                    Console.WriteLine("Pentagon perimeter is: {0}", this.Lengthside(this.p1, this.p2) + this.Lengthside(this.p2, this.p3) + this.Lengthside(this.p3, this.p4) + this.Lengthside(this.p4, this.p5) + this.Lengthside(this.p5, this.p1));
                    break;
            }
        }
    }
}
