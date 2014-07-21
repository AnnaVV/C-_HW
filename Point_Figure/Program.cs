using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure triangle = new Figure(new Point("A", 1, 1), new Point("B", 2, 3), new Point("C", 4, 2));

            Console.WriteLine(triangle.FigureName);
            triangle.PerimeterCalculator();

            Console.ReadLine();
        }
    }
}
