using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    class BadPupil: Pupil
    {
        override public void Study()
        {
            Console.WriteLine("Bad pupil: studying bad");
        }
        override public void Read()
        {
            Console.WriteLine("Bad pupil: reading bad");
        }
        override public void Write()
        {
            Console.WriteLine("Bad pupil: writing bad");
        }
        override public void Relax()
        {
            Console.WriteLine("Bad pupil: relaxing bad");
        }
    }
}
