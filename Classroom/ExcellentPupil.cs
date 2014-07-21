using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    class ExcellentPupil: Pupil
    {
        override public void Study()
        {
            Console.WriteLine("Excellent pupil: studying excellently");
        }
        override public void Read()
        {
            Console.WriteLine("Excellent pupil: reading excellently");
        }
        override public void Write()
        {
            Console.WriteLine("Excellent pupil: writing excellently");
        }
        override public void Relax()
        {
            Console.WriteLine("Excellent pupil: relaxing excellently");
        }
    }
}
