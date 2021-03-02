using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    class BadPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Bad pupil almost doesn`t read");
        }

        public override void Relax()
        {
            Console.WriteLine("Bad pupil doesn`t deny himself in relax");
        }

        public override void Study()
        {
            Console.WriteLine("Bad pupil studies only the day before deadline");
        }

        public override void Write()
        {
            Console.WriteLine("Bad pupil writes only when cheats");
        }
    }
}
