using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    class Program
    {
        static void Main(string[] args)
        {
            Classroom classA = new Classroom(new ExcellentPupil(), new BadPupil(), new GoodPupil());

            foreach (Pupil child in classA.Pupils)
            {
                child.Study();
                child.Read();
                child.Write();
                child.Relax();
            }

            Console.ReadLine();
         }
    }
}
