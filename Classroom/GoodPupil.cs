using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    class GoodPupil:Pupil
    {
        override public void Study()
        {
            Console.WriteLine("Good pupil: studying good");
        }
        override public void Read()
        {
            Console.WriteLine("Good pupil: reading good");
        }
        override public void Write()
        {
            Console.WriteLine("Good pupil: writing good");
        }
        override public void Relax()
        {
            Console.WriteLine("Good pupil: relaxing good");
        }
    }
}
