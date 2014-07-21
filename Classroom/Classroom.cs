using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    class Classroom
    {
        private List<Pupil> _pupils = new List<Pupil>();

        internal List<Pupil> Pupils
        {
            get { return _pupils; }
            set { _pupils = value; }
        }

        
        public Classroom(Pupil pupil1, Pupil pupil2)
        {
            this._pupils.Add(pupil1);
            this._pupils.Add(pupil2);
        }

        public Classroom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
            :this(pupil1,pupil2)
        {
            this._pupils.Add(pupil3);
            
        }

        public Classroom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
            : this(pupil1, pupil2, pupil3)
        {
            this._pupils.Add(pupil4);

        }
    }
}
