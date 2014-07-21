using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_HW
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter rectangle sides lenght");
            Console.WriteLine("side 1 =");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("side 2 =");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle1 = new Rectangle(side1, side2);

            Console.WriteLine("Rectangle area is: {0}",rectangle1.Area);
            Console.WriteLine("Rectangle perimeter is: {0}", rectangle1.Perimeter);

            Console.ReadLine();
        }
    }
}
